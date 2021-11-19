using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.IO;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using System.Diagnostics;

namespace DeviceAnalyzer
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>        

        private bool connected = false;

        int IR_RAW;
        int RED_RAW;
        int IR_FILT;
        int RED_FILT;
        int BPM;
        int SaO2;
        String[] T = new string[] { "1", "2", "3", "4", "5", "6", "7" };
        int SelectedT;

        bool Run;
        bool Saving;
        bool DrawIR_RAW;
        bool DrawRED_RAW;
        bool DrawFILT;
        bool fileopen = false;

        bool Drawx1 = false;
        bool Drawx2 = false;
        bool Drawy1 = false;
        bool Drawy2 = false;
        //false = x1, true = x2
        bool x1ORx2;
        //false = y1, true = y2
        bool y1ORy2;
        float x1 = 50;
        float x2 = 50;
        float y1 = 50;
        float y2 = 50;


        DateTime logtime;
        DateTime drawtime;

        StreamWriter outfile;
        string filename = "log";
        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        bool WriteType;

        object filemutex = new object();
        object portmutex = new object();

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        OpenFileDialog ofd = new OpenFileDialog();

        public MainForm()
        {
            InitializeComponent();
            PortConfig.Items.AddRange(SerialPort.GetPortNames());
            TimeSet.Items.AddRange(T);
            TimeSet.SelectedItem = "3";
            SelectedT = 3;
            Run = true;
            Saving = false;
            WriteType = false;
            AppendButton.Checked = false;
            OverwriteButton.Checked = true;
            LoggingDataGroup.Enabled = false;
            GraphGroup.Enabled = false;
            MeasuredParamGroup.Enabled = false;
            checkBoxRED_RAW.Checked = true;
            checkBoxIR_RAW.Checked = true;
            checkBoxFILTERED.Checked = false;
            btnClose.Enabled = false;
            VerticaltrackBar.Enabled = false;
            HorizontaltrackBar.Enabled = false;
            VerticaltrackBar.Value = 50;
            HorizontaltrackBar.Value = 50;
            this.Load += new System.EventHandler(this.MainForm_GetData);
        }

        private void MainForm_GetData(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(GetSerialData));
        }

        private void GetSerialData(object state)
        {
            while (true)
            {
                lock (portmutex)
                {
                    if (connected)
                    {
                        string s = SerialPort.ReadLine();
                        if (s.Split('\t').Length == 3)
                        {
                            if (s.Split('\t')[0] == "BEAT")
                            {
                                BPM = int.Parse(s.Split('\t')[1]);
                                SaO2 = int.Parse(s.Split('\t')[2]);
                            }
                            else if (s.Split('\t')[0] == "FILT")
                            {
                                IR_FILT = int.Parse(s.Split('\t')[1]);
                                RED_FILT = int.Parse(s.Split('\t')[2]);
                            }
                            else if (s.Split('\t')[0] == "RAW")
                            {
                                IR_RAW = int.Parse(s.Split('\t')[1]);
                                RED_RAW = int.Parse(s.Split('\t')[2]);
                            }
                        }
                        lock (filemutex)
                        {
                            if (Saving)
                            {
                                logtime = DateTime.Now;
                                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", logtime.Hour, logtime.Minute, logtime.Second, logtime.Millisecond);
                                outfile.Write(elapsedTime + ';' + IR_RAW + ';' + RED_RAW + "\n");
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += delegate
            {
                if (Run)
                {
                    signControl1.IR_RAWBuffer[signControl1.StartIndex] = IR_RAW;
                    signControl1.RED_RAWBuffer[signControl1.StartIndex] = RED_RAW;
                    signControl1.IR_FILTBuffer[signControl1.StartIndex] = IR_FILT;
                    signControl1.RED_FILTBuffer[signControl1.StartIndex] = RED_FILT;
                    signControl1.StartIndex = (signControl1.StartIndex + 1) % 500;
                }
                signControl1.T = SelectedT;
                signControl1.DrawRED_RAW = DrawRED_RAW;
                signControl1.DrawIR_RAW = DrawIR_RAW;
                signControl1.DrawFILT = DrawFILT;
                signControl1.Drawx1 = Drawx1;
                signControl1.Drawx2 = Drawx2;
                signControl1.Drawy1 = Drawy1;
                signControl1.Drawy2 = Drawy2;
                signControl1.x1 = x1;
                signControl1.x2 = x2;
                signControl1.y1 = y1;
                signControl1.y2 = y2;
                y1markerlabel.Text = ((int)signControl1.y1value).ToString();
                y2markerlabel.Text = ((int)signControl1.y2value).ToString();
                if (Run)
                {
                    MeasuredPulselabel.Text = ((int)BPM).ToString();
                    MeasuredSaO2lable.Text = ((int)SaO2).ToString() + '%';
                }
                if (y2checkBox.Checked && y2checkBox.Checked)
                    dylabel.Text = ((int)signControl1.y2value - signControl1.y1value).ToString();
                else
                    dylabel.Text = "NaN";
                if (x1checkBox.Checked && x2checkBox.Checked)
                    dxlabel.Text = ((x2 - x1) * SelectedT / 100).ToString() + " s";
                else
                    dxlabel.Text = "NaN";
                this.signControl1.Invalidate();
            };

            timer.Start();
        }

        private void bntOpen_Click(object sender, EventArgs e)
        {
            lock (portmutex)
            {
                try
                {
                    SerialPort.PortName = PortConfig.Text;
                    SerialPort.BaudRate = 115200;
                    SerialPort.DataBits = 8;
                    SerialPort.StopBits = (StopBits)1;
                    SerialPort.Parity = (Parity)0;

                    if (!connected)
                        SerialPort.Open();
                    if (SerialPort.IsOpen)
                    {
                        connected = true;
                        IsConnectedLable.Text = "Connected";
                        PortConfig.Enabled = false;
                        LoggingDataGroup.Enabled = true;
                        GraphGroup.Enabled = true;
                        MeasuredParamGroup.Enabled = true;
                        bntOpen.Enabled = false;
                        btnClose.Enabled = true;
                        btnStopGraph.Text = "STOP";
                        btnStopGraph.BackColor = Color.Red;
                        VerticaltrackBar.Enabled = true;
                        HorizontaltrackBar.Enabled = true;
                        Run = true;
                        this.Invalidate();
                    }

                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lock (portmutex)
            {
                if (connected)
                {
                    SerialPort.Close();
                    if (!SerialPort.IsOpen)
                    {
                        connected = false;
                        IsConnectedLable.Text = "Not Connected";
                        PortConfig.Enabled = true;
                        LoggingDataGroup.Enabled = false;
                        GraphGroup.Enabled = false;
                        MeasuredParamGroup.Enabled = false;
                        bntOpen.Enabled = true;
                        btnClose.Enabled = false;
                        Run = false;
                        btnStopGraph.Text = "START";
                        btnStopGraph.BackColor = Color.Green;
                        VerticaltrackBar.Enabled = false;
                        HorizontaltrackBar.Enabled = false;
                        if (fileopen)
                            CloseFile();
                        this.Invalidate();
                    }
                }
            }
        }


        //set the write type to append
        private void AppendButton_CheckedChanged(object sender, EventArgs e)
        {
            WriteType = true;
        }

        //set the write type to overwrite
        private void OverwriteButton_CheckedChanged(object sender, EventArgs e)
        {
            WriteType = false;
        }

        //port config
        private void PortConfig_Click(object sender, EventArgs e)
        {
            PortConfig.Text = "";
            PortConfig.Items.Clear();
            PortConfig.Items.AddRange(SerialPort.GetPortNames());
        }

        private void TimeSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedT = int.Parse((string)TimeSet.SelectedItem);
        }

        private void btnStopGraph_Click(object sender, EventArgs e)
        {
            StopGraph();
        }

        //Start and stop Recording
        private void btnRecord_Click(object sender, EventArgs e)
        {
            if(!Saving)
            {
                Saving = true;
                btnRecord.Text = "Stop recording";
                this.Invalidate();
            }
            else
            {
                Saving = false;
                btnRecord.Text = "Start recording";
                this.Invalidate();
            }
        }

        private void FilenameBox_Click(object sender, EventArgs e)
        {
            FilenameBox.Text = "";
            FilenameBox.ForeColor = Color.Black;
        }

        private void Openbtn_Click(object sender, EventArgs e)
        {
            if (FilenameBox.Text == "Filename")
            {
                MessageBox.Show("Enter filename first!", "Missing filename");
                return;
            }
            fbd.SelectedPath = filepath;
            DialogResult dialogresult = fbd.ShowDialog();
            if (dialogresult == DialogResult.OK)
                filepath = fbd.SelectedPath;
            else if (dialogresult == DialogResult.Cancel)
                return;
            lock (filemutex)
            {
                outfile = new StreamWriter(filepath + "\\" + filename + ".csv", false);
                outfile.Write("Time [ms];IR RAW;RED RAW\n");
                AppendButton.Enabled = false;
                OverwriteButton.Enabled = false;
                OpenNewbtn.Enabled = false;
                OpenOldbtn.Enabled = false;
                FilenameBox.Enabled = false;
                btnRecord.Enabled = true;
                CloseFilebtn.Enabled = true;
                fileopen = true;
                this.Invalidate();
            }
        }

        private void OpenOldbtn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "(*csv)|*csv";
            ofd.FileName = "";
            DialogResult dialogresult = ofd.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                return;
            }
            else if (dialogresult == DialogResult.OK)
            {
                string[] temp = new string[2];
                filename = ofd.SafeFileName;
                temp[0] = ofd.SafeFileName;
                string tempfull = ofd.FileName;
                temp = tempfull.Split(temp, StringSplitOptions.None);
                filepath = temp[0];
                Console.WriteLine(filepath);
            }
            lock (filemutex)
            {
                outfile = new StreamWriter(filepath + "\\" + filename, WriteType);
                if (OverwriteButton.Checked)
                    outfile.Write("Time [ms];IR RAW;RED RAW\n");
                AppendButton.Enabled = false;
                OverwriteButton.Enabled = false;
                OpenNewbtn.Enabled = false;
                OpenOldbtn.Enabled = false;
                FilenameBox.Enabled = false;
                btnRecord.Enabled = true;
                CloseFilebtn.Enabled = true;
                fileopen = true;
                this.Invalidate();
            }   
        }

        private void CloseFilebtn_Click(object sender, EventArgs e)
        {
            Saving = false;
            btnRecord.Text = "Start recording";
            this.Invalidate();
            CloseFile();
        }

        private void FilenameBox_Leave(object sender, EventArgs e)
        {
            filename = FilenameBox.Text;
        }

        private void CloseFile()
        {
            lock (filemutex)
            {
                outfile.Close();
                AppendButton.Enabled = true;
                OverwriteButton.Enabled = true;
                OpenNewbtn.Enabled = true;
                OpenOldbtn.Enabled = true;
                FilenameBox.Enabled = true;
                Saving = false;
                btnRecord.Enabled = false;
                CloseFilebtn.Enabled = false;
                fileopen = false;
                this.Invalidate();
            }
        }

        private void StopGraph()
        {
            if (Run)
            {
                btnStopGraph.Text = "START";
                btnStopGraph.BackColor = Color.Green;
                Run = false;
            }
            else
            {
                btnStopGraph.Text = "STOP";
                btnStopGraph.BackColor = Color.Red;
                Run = true;
            }
        }

        private void x1checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (x1checkBox.Checked)
            {
                Drawx1 = true;
                x1ORx2 = false;
                x1radioButton.Checked = true;
                x2radioButton.Checked = false;
            }
            else if(x2checkBox.Checked)
            {
                Drawx1 = false;
                x1ORx2 = true;
                x1radioButton.Checked = false;
                x2radioButton.Checked = true;
            }
            else
            {
                Drawx1 = false;
                x1radioButton.Checked = false;
                x2radioButton.Checked = false;
            }
        }

        private void y1checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (y1checkBox.Checked)
            {
                Drawy1 = true;
                y1ORy2 = false;
                y1radioButton.Checked = true;
                y2radioButton.Checked = false;
            }
            else if(y2checkBox.Checked)
            {
                Drawy1 = false;
                y1ORy2 = true;
                y1radioButton.Checked = false;
                y2radioButton.Checked = true;
            }
            else
            {
                Drawy1 = false;
                y1radioButton.Checked = false;
                y2radioButton.Checked = false;
            }    
        }

        private void x2checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (x2checkBox.Checked)
            {
                Drawx2 = true;
                x1ORx2 = true;
                x1radioButton.Checked = false;
                x2radioButton.Checked = true;
            }
            else if(x1checkBox.Checked)
            {
                Drawx2 = false;
                x1ORx2 = false;
                x1radioButton.Checked = true;
                x2radioButton.Checked = false;
            }
            else
            {
                Drawx2 = false;
                x1radioButton.Checked = false;
                x2radioButton.Checked = false;
            }
        }

        private void y2checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (y2checkBox.Checked)
            {
                Drawy2 = true;
                y1ORy2 = true;
                y1radioButton.Checked = false;
                y2radioButton.Checked = true;
            }
            else if(y1checkBox.Checked)
            {
                Drawy2 = false;
                y1ORy2 = false;
                y1radioButton.Checked = true;
                y2radioButton.Checked = false;
            }
            else
            {
                Drawy2 = false;
                y1radioButton.Checked = false;
                y2radioButton.Checked = false;
            }
        }

        private void y1radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (y1radioButton.Checked)
            {
                y1ORy2 = false;
                VerticaltrackBar.Value = (int)y1;
            }
        }

        private void y2radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (y2radioButton.Checked)
            {
                y1ORy2 = true;
                VerticaltrackBar.Value = (int)y2;
            }
        }

        private void x1radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (x1radioButton.Checked)
            {
                x1ORx2 = false;
                HorizontaltrackBar.Value = (int)x1;
            }
        }

        private void x2radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (x2radioButton.Checked)
            {
                x1ORx2 = true;
                HorizontaltrackBar.Value = (int)x2;
            }
        }

        private void VerticaltrackBar_Scroll(object sender, EventArgs e)
        {
            if(y1checkBox.Checked || y2checkBox.Checked)
            {
                if(y1ORy2)
                    y2 = VerticaltrackBar.Value;
                else
                    y1 = VerticaltrackBar.Value;
            }
        }

        private void HorizontaltrackBar_Scroll(object sender, EventArgs e)
        {
            if (x1checkBox.Checked || x2checkBox.Checked)
            {
                if (x1ORx2)
                    x2 = HorizontaltrackBar.Value;
                else
                    x1 = HorizontaltrackBar.Value;
            }
        }

        private void checkBoxRED_RAW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRED_RAW.Checked)
            {
                DrawRED_RAW = true;
                checkBoxFILTERED.Checked = false;
                DrawFILT = false;
            }
            else
                DrawRED_RAW = false;
        }

        private void checkBoxIR_RAW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIR_RAW.Checked)
            {
                DrawIR_RAW = true;
                checkBoxFILTERED.Checked = false;
                DrawFILT = false;
            }
            else
                DrawIR_RAW = false;
        }

        private void checkBoxFILTERED_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFILTERED.Checked)
            {
                DrawFILT = true;
                checkBoxIR_RAW.Checked = false;
                checkBoxRED_RAW.Checked = false;
                DrawIR_RAW = false;
                DrawRED_RAW = false;
            }
            else
                DrawFILT = false;
        }
    }
}
