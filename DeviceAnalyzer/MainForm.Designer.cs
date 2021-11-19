namespace DeviceAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PortSettinsGroup = new System.Windows.Forms.GroupBox();
            this.IsConnectedLable = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.bntOpen = new System.Windows.Forms.Button();
            this.PortConfig = new System.Windows.Forms.ComboBox();
            this.PortLable = new System.Windows.Forms.Label();
            this.LoggingDataGroup = new System.Windows.Forms.GroupBox();
            this.CloseFilebtn = new System.Windows.Forms.Button();
            this.OpenOldbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FilenameBox = new System.Windows.Forms.TextBox();
            this.AppendButton = new System.Windows.Forms.RadioButton();
            this.OpenNewbtn = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.OverwriteButton = new System.Windows.Forms.RadioButton();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnStopGraph = new System.Windows.Forms.Button();
            this.GraphGroup = new System.Windows.Forms.GroupBox();
            this.y1checkBox = new System.Windows.Forms.CheckBox();
            this.checkBoxFILTERED = new System.Windows.Forms.CheckBox();
            this.xradiogroup = new System.Windows.Forms.GroupBox();
            this.x2radioButton = new System.Windows.Forms.RadioButton();
            this.x1radioButton = new System.Windows.Forms.RadioButton();
            this.y2checkBox = new System.Windows.Forms.CheckBox();
            this.yradiogroup = new System.Windows.Forms.GroupBox();
            this.y2radioButton = new System.Windows.Forms.RadioButton();
            this.y1radioButton = new System.Windows.Forms.RadioButton();
            this.x2checkBox = new System.Windows.Forms.CheckBox();
            this.x1checkBox = new System.Windows.Forms.CheckBox();
            this.checkBoxRED_RAW = new System.Windows.Forms.CheckBox();
            this.checkBoxIR_RAW = new System.Windows.Forms.CheckBox();
            this.TimeSet = new System.Windows.Forms.ComboBox();
            this.KijelzohosszLabel = new System.Windows.Forms.Label();
            this.dylabel = new System.Windows.Forms.Label();
            this.y2markerlabel = new System.Windows.Forms.Label();
            this.deltayLabel = new System.Windows.Forms.Label();
            this.y1markerlabel = new System.Windows.Forms.Label();
            this.y2Label = new System.Windows.Forms.Label();
            this.dxlabel = new System.Windows.Forms.Label();
            this.y1Label = new System.Windows.Forms.Label();
            this.deltaxLabel = new System.Windows.Forms.Label();
            this.PulseLabel = new System.Windows.Forms.Label();
            this.MeasuredPulselabel = new System.Windows.Forms.Label();
            this.HorizontaltrackBar = new System.Windows.Forms.TrackBar();
            this.VerticaltrackBar = new System.Windows.Forms.TrackBar();
            this.MeasuredParamGroup = new System.Windows.Forms.GroupBox();
            this.MeasuredSaO2lable = new System.Windows.Forms.Label();
            this.SaO2lable = new System.Windows.Forms.Label();
            this.signControl1 = new DeviceAnalyzer.SignControl();
            this.PortSettinsGroup.SuspendLayout();
            this.LoggingDataGroup.SuspendLayout();
            this.GraphGroup.SuspendLayout();
            this.xradiogroup.SuspendLayout();
            this.yradiogroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontaltrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticaltrackBar)).BeginInit();
            this.MeasuredParamGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortSettinsGroup
            // 
            this.PortSettinsGroup.Controls.Add(this.IsConnectedLable);
            this.PortSettinsGroup.Controls.Add(this.btnClose);
            this.PortSettinsGroup.Controls.Add(this.bntOpen);
            this.PortSettinsGroup.Controls.Add(this.PortConfig);
            this.PortSettinsGroup.Controls.Add(this.PortLable);
            this.PortSettinsGroup.Location = new System.Drawing.Point(8, 10);
            this.PortSettinsGroup.Name = "PortSettinsGroup";
            this.PortSettinsGroup.Size = new System.Drawing.Size(145, 108);
            this.PortSettinsGroup.TabIndex = 9;
            this.PortSettinsGroup.TabStop = false;
            this.PortSettinsGroup.Text = "Port Settings";
            // 
            // IsConnectedLable
            // 
            this.IsConnectedLable.AutoSize = true;
            this.IsConnectedLable.Location = new System.Drawing.Point(36, 70);
            this.IsConnectedLable.Name = "IsConnectedLable";
            this.IsConnectedLable.Size = new System.Drawing.Size(79, 13);
            this.IsConnectedLable.TabIndex = 4;
            this.IsConnectedLable.Text = "Not Connected";
            this.IsConnectedLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(76, 45);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bntOpen
            // 
            this.bntOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntOpen.Location = new System.Drawing.Point(7, 45);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(63, 22);
            this.bntOpen.TabIndex = 2;
            this.bntOpen.Text = "Open";
            this.bntOpen.UseVisualStyleBackColor = true;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // PortConfig
            // 
            this.PortConfig.FormattingEnabled = true;
            this.PortConfig.Location = new System.Drawing.Point(75, 18);
            this.PortConfig.Name = "PortConfig";
            this.PortConfig.Size = new System.Drawing.Size(63, 21);
            this.PortConfig.TabIndex = 1;
            this.PortConfig.Click += new System.EventHandler(this.PortConfig_Click);
            // 
            // PortLable
            // 
            this.PortLable.AutoSize = true;
            this.PortLable.Location = new System.Drawing.Point(20, 21);
            this.PortLable.Name = "PortLable";
            this.PortLable.Size = new System.Drawing.Size(26, 13);
            this.PortLable.TabIndex = 0;
            this.PortLable.Text = "Port";
            // 
            // LoggingDataGroup
            // 
            this.LoggingDataGroup.Controls.Add(this.CloseFilebtn);
            this.LoggingDataGroup.Controls.Add(this.OpenOldbtn);
            this.LoggingDataGroup.Controls.Add(this.label2);
            this.LoggingDataGroup.Controls.Add(this.FilenameBox);
            this.LoggingDataGroup.Controls.Add(this.AppendButton);
            this.LoggingDataGroup.Controls.Add(this.OpenNewbtn);
            this.LoggingDataGroup.Controls.Add(this.btnRecord);
            this.LoggingDataGroup.Controls.Add(this.OverwriteButton);
            this.LoggingDataGroup.Location = new System.Drawing.Point(474, 10);
            this.LoggingDataGroup.Name = "LoggingDataGroup";
            this.LoggingDataGroup.Size = new System.Drawing.Size(370, 67);
            this.LoggingDataGroup.TabIndex = 10;
            this.LoggingDataGroup.TabStop = false;
            this.LoggingDataGroup.Text = "Logging Data";
            // 
            // CloseFilebtn
            // 
            this.CloseFilebtn.Location = new System.Drawing.Point(299, 15);
            this.CloseFilebtn.Name = "CloseFilebtn";
            this.CloseFilebtn.Size = new System.Drawing.Size(66, 22);
            this.CloseFilebtn.TabIndex = 46;
            this.CloseFilebtn.Text = "Close File";
            this.CloseFilebtn.UseVisualStyleBackColor = true;
            this.CloseFilebtn.Click += new System.EventHandler(this.CloseFilebtn_Click);
            // 
            // OpenOldbtn
            // 
            this.OpenOldbtn.BackColor = System.Drawing.Color.Transparent;
            this.OpenOldbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenOldbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenOldbtn.Location = new System.Drawing.Point(148, 42);
            this.OpenOldbtn.Name = "OpenOldbtn";
            this.OpenOldbtn.Size = new System.Drawing.Size(110, 22);
            this.OpenOldbtn.TabIndex = 45;
            this.OpenOldbtn.Text = "Open Existing File";
            this.OpenOldbtn.UseVisualStyleBackColor = false;
            this.OpenOldbtn.Click += new System.EventHandler(this.OpenOldbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "New file:";
            // 
            // FilenameBox
            // 
            this.FilenameBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FilenameBox.Location = new System.Drawing.Point(63, 16);
            this.FilenameBox.Name = "FilenameBox";
            this.FilenameBox.Size = new System.Drawing.Size(164, 20);
            this.FilenameBox.TabIndex = 43;
            this.FilenameBox.Text = "Filename";
            this.FilenameBox.Click += new System.EventHandler(this.FilenameBox_Click);
            this.FilenameBox.Leave += new System.EventHandler(this.FilenameBox_Leave);
            // 
            // AppendButton
            // 
            this.AppendButton.AutoSize = true;
            this.AppendButton.Location = new System.Drawing.Point(80, 45);
            this.AppendButton.Name = "AppendButton";
            this.AppendButton.Size = new System.Drawing.Size(62, 17);
            this.AppendButton.TabIndex = 9;
            this.AppendButton.TabStop = true;
            this.AppendButton.Text = "Append";
            this.AppendButton.UseVisualStyleBackColor = true;
            this.AppendButton.CheckedChanged += new System.EventHandler(this.AppendButton_CheckedChanged);
            // 
            // OpenNewbtn
            // 
            this.OpenNewbtn.BackColor = System.Drawing.Color.Transparent;
            this.OpenNewbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenNewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenNewbtn.Location = new System.Drawing.Point(230, 15);
            this.OpenNewbtn.Name = "OpenNewbtn";
            this.OpenNewbtn.Size = new System.Drawing.Size(63, 22);
            this.OpenNewbtn.TabIndex = 39;
            this.OpenNewbtn.Text = "Open";
            this.OpenNewbtn.UseVisualStyleBackColor = false;
            this.OpenNewbtn.Click += new System.EventHandler(this.Openbtn_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecord.Location = new System.Drawing.Point(264, 42);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(101, 22);
            this.btnRecord.TabIndex = 37;
            this.btnRecord.Text = "Start recording";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // OverwriteButton
            // 
            this.OverwriteButton.AutoSize = true;
            this.OverwriteButton.Location = new System.Drawing.Point(10, 45);
            this.OverwriteButton.Name = "OverwriteButton";
            this.OverwriteButton.Size = new System.Drawing.Size(70, 17);
            this.OverwriteButton.TabIndex = 10;
            this.OverwriteButton.TabStop = true;
            this.OverwriteButton.Text = "Overwrite";
            this.OverwriteButton.UseVisualStyleBackColor = true;
            this.OverwriteButton.CheckedChanged += new System.EventHandler(this.OverwriteButton_CheckedChanged);
            // 
            // btnStopGraph
            // 
            this.btnStopGraph.BackColor = System.Drawing.Color.Red;
            this.btnStopGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStopGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStopGraph.Location = new System.Drawing.Point(6, 58);
            this.btnStopGraph.Name = "btnStopGraph";
            this.btnStopGraph.Size = new System.Drawing.Size(84, 44);
            this.btnStopGraph.TabIndex = 5;
            this.btnStopGraph.Text = "STOP";
            this.btnStopGraph.UseVisualStyleBackColor = false;
            this.btnStopGraph.Click += new System.EventHandler(this.btnStopGraph_Click);
            // 
            // GraphGroup
            // 
            this.GraphGroup.Controls.Add(this.y1checkBox);
            this.GraphGroup.Controls.Add(this.checkBoxFILTERED);
            this.GraphGroup.Controls.Add(this.xradiogroup);
            this.GraphGroup.Controls.Add(this.y2checkBox);
            this.GraphGroup.Controls.Add(this.yradiogroup);
            this.GraphGroup.Controls.Add(this.x2checkBox);
            this.GraphGroup.Controls.Add(this.x1checkBox);
            this.GraphGroup.Controls.Add(this.checkBoxRED_RAW);
            this.GraphGroup.Controls.Add(this.checkBoxIR_RAW);
            this.GraphGroup.Controls.Add(this.TimeSet);
            this.GraphGroup.Controls.Add(this.KijelzohosszLabel);
            this.GraphGroup.Controls.Add(this.btnStopGraph);
            this.GraphGroup.Location = new System.Drawing.Point(159, 10);
            this.GraphGroup.Name = "GraphGroup";
            this.GraphGroup.Size = new System.Drawing.Size(309, 108);
            this.GraphGroup.TabIndex = 11;
            this.GraphGroup.TabStop = false;
            this.GraphGroup.Text = "Graph Settings";
            // 
            // y1checkBox
            // 
            this.y1checkBox.AutoSize = true;
            this.y1checkBox.Location = new System.Drawing.Point(197, 60);
            this.y1checkBox.Name = "y1checkBox";
            this.y1checkBox.Size = new System.Drawing.Size(37, 17);
            this.y1checkBox.TabIndex = 39;
            this.y1checkBox.Text = "y1";
            this.y1checkBox.UseVisualStyleBackColor = true;
            this.y1checkBox.CheckedChanged += new System.EventHandler(this.y1checkBox_CheckedChanged);
            // 
            // checkBoxFILTERED
            // 
            this.checkBoxFILTERED.AutoSize = true;
            this.checkBoxFILTERED.Location = new System.Drawing.Point(101, 60);
            this.checkBoxFILTERED.Name = "checkBoxFILTERED";
            this.checkBoxFILTERED.Size = new System.Drawing.Size(97, 17);
            this.checkBoxFILTERED.TabIndex = 57;
            this.checkBoxFILTERED.Text = "Filtered Signals";
            this.checkBoxFILTERED.UseVisualStyleBackColor = true;
            this.checkBoxFILTERED.CheckedChanged += new System.EventHandler(this.checkBoxFILTERED_CheckedChanged);
            // 
            // xradiogroup
            // 
            this.xradiogroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xradiogroup.Controls.Add(this.x2radioButton);
            this.xradiogroup.Controls.Add(this.x1radioButton);
            this.xradiogroup.Location = new System.Drawing.Point(241, 13);
            this.xradiogroup.Name = "xradiogroup";
            this.xradiogroup.Size = new System.Drawing.Size(62, 40);
            this.xradiogroup.TabIndex = 55;
            this.xradiogroup.TabStop = false;
            // 
            // x2radioButton
            // 
            this.x2radioButton.AutoSize = true;
            this.x2radioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.x2radioButton.Location = new System.Drawing.Point(34, 7);
            this.x2radioButton.Name = "x2radioButton";
            this.x2radioButton.Size = new System.Drawing.Size(22, 30);
            this.x2radioButton.TabIndex = 53;
            this.x2radioButton.TabStop = true;
            this.x2radioButton.Text = "x2";
            this.x2radioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.x2radioButton.UseVisualStyleBackColor = true;
            this.x2radioButton.CheckedChanged += new System.EventHandler(this.x2radioButton_CheckedChanged);
            // 
            // x1radioButton
            // 
            this.x1radioButton.AutoSize = true;
            this.x1radioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.x1radioButton.Location = new System.Drawing.Point(6, 7);
            this.x1radioButton.Name = "x1radioButton";
            this.x1radioButton.Size = new System.Drawing.Size(22, 30);
            this.x1radioButton.TabIndex = 52;
            this.x1radioButton.TabStop = true;
            this.x1radioButton.Text = "x1";
            this.x1radioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.x1radioButton.UseVisualStyleBackColor = true;
            this.x1radioButton.CheckedChanged += new System.EventHandler(this.x1radioButton_CheckedChanged);
            // 
            // y2checkBox
            // 
            this.y2checkBox.AutoSize = true;
            this.y2checkBox.Location = new System.Drawing.Point(197, 83);
            this.y2checkBox.Name = "y2checkBox";
            this.y2checkBox.Size = new System.Drawing.Size(37, 17);
            this.y2checkBox.TabIndex = 40;
            this.y2checkBox.Text = "y2";
            this.y2checkBox.UseVisualStyleBackColor = true;
            this.y2checkBox.CheckedChanged += new System.EventHandler(this.y2checkBox_CheckedChanged);
            // 
            // yradiogroup
            // 
            this.yradiogroup.Controls.Add(this.y2radioButton);
            this.yradiogroup.Controls.Add(this.y1radioButton);
            this.yradiogroup.Location = new System.Drawing.Point(241, 58);
            this.yradiogroup.Name = "yradiogroup";
            this.yradiogroup.Size = new System.Drawing.Size(62, 40);
            this.yradiogroup.TabIndex = 54;
            this.yradiogroup.TabStop = false;
            // 
            // y2radioButton
            // 
            this.y2radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.y2radioButton.AutoSize = true;
            this.y2radioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.y2radioButton.Location = new System.Drawing.Point(34, 7);
            this.y2radioButton.Name = "y2radioButton";
            this.y2radioButton.Size = new System.Drawing.Size(22, 30);
            this.y2radioButton.TabIndex = 51;
            this.y2radioButton.TabStop = true;
            this.y2radioButton.Text = "y2";
            this.y2radioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.y2radioButton.UseVisualStyleBackColor = true;
            this.y2radioButton.CheckedChanged += new System.EventHandler(this.y2radioButton_CheckedChanged);
            // 
            // y1radioButton
            // 
            this.y1radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.y1radioButton.AutoSize = true;
            this.y1radioButton.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.y1radioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.y1radioButton.Location = new System.Drawing.Point(6, 7);
            this.y1radioButton.Name = "y1radioButton";
            this.y1radioButton.Size = new System.Drawing.Size(22, 30);
            this.y1radioButton.TabIndex = 50;
            this.y1radioButton.TabStop = true;
            this.y1radioButton.Text = "y1";
            this.y1radioButton.UseVisualStyleBackColor = true;
            this.y1radioButton.CheckedChanged += new System.EventHandler(this.y1radioButton_CheckedChanged);
            // 
            // x2checkBox
            // 
            this.x2checkBox.AutoSize = true;
            this.x2checkBox.Location = new System.Drawing.Point(197, 36);
            this.x2checkBox.Name = "x2checkBox";
            this.x2checkBox.Size = new System.Drawing.Size(37, 17);
            this.x2checkBox.TabIndex = 38;
            this.x2checkBox.Text = "x2";
            this.x2checkBox.UseVisualStyleBackColor = true;
            this.x2checkBox.CheckedChanged += new System.EventHandler(this.x2checkBox_CheckedChanged);
            // 
            // x1checkBox
            // 
            this.x1checkBox.AutoSize = true;
            this.x1checkBox.Location = new System.Drawing.Point(197, 13);
            this.x1checkBox.Name = "x1checkBox";
            this.x1checkBox.Size = new System.Drawing.Size(37, 17);
            this.x1checkBox.TabIndex = 37;
            this.x1checkBox.Text = "x1";
            this.x1checkBox.UseVisualStyleBackColor = true;
            this.x1checkBox.CheckedChanged += new System.EventHandler(this.x1checkBox_CheckedChanged);
            // 
            // checkBoxRED_RAW
            // 
            this.checkBoxRED_RAW.AutoSize = true;
            this.checkBoxRED_RAW.Location = new System.Drawing.Point(101, 36);
            this.checkBoxRED_RAW.Name = "checkBoxRED_RAW";
            this.checkBoxRED_RAW.Size = new System.Drawing.Size(74, 17);
            this.checkBoxRED_RAW.TabIndex = 36;
            this.checkBoxRED_RAW.Text = "Raw RED";
            this.checkBoxRED_RAW.UseVisualStyleBackColor = true;
            this.checkBoxRED_RAW.CheckedChanged += new System.EventHandler(this.checkBoxRED_RAW_CheckedChanged);
            // 
            // checkBoxIR_RAW
            // 
            this.checkBoxIR_RAW.AutoSize = true;
            this.checkBoxIR_RAW.Location = new System.Drawing.Point(101, 13);
            this.checkBoxIR_RAW.Name = "checkBoxIR_RAW";
            this.checkBoxIR_RAW.Size = new System.Drawing.Size(62, 17);
            this.checkBoxIR_RAW.TabIndex = 35;
            this.checkBoxIR_RAW.Text = "Raw IR";
            this.checkBoxIR_RAW.UseVisualStyleBackColor = true;
            this.checkBoxIR_RAW.CheckedChanged += new System.EventHandler(this.checkBoxIR_RAW_CheckedChanged);
            // 
            // TimeSet
            // 
            this.TimeSet.FormattingEnabled = true;
            this.TimeSet.Location = new System.Drawing.Point(9, 32);
            this.TimeSet.Name = "TimeSet";
            this.TimeSet.Size = new System.Drawing.Size(81, 21);
            this.TimeSet.TabIndex = 34;
            this.TimeSet.SelectedIndexChanged += new System.EventHandler(this.TimeSet_SelectedIndexChanged);
            // 
            // KijelzohosszLabel
            // 
            this.KijelzohosszLabel.AutoSize = true;
            this.KijelzohosszLabel.Location = new System.Drawing.Point(6, 16);
            this.KijelzohosszLabel.Name = "KijelzohosszLabel";
            this.KijelzohosszLabel.Size = new System.Drawing.Size(77, 13);
            this.KijelzohosszLabel.TabIndex = 27;
            this.KijelzohosszLabel.Text = "Display time (s)";
            // 
            // dylabel
            // 
            this.dylabel.AutoSize = true;
            this.dylabel.Location = new System.Drawing.Point(88, 16);
            this.dylabel.Name = "dylabel";
            this.dylabel.Size = new System.Drawing.Size(13, 13);
            this.dylabel.TabIndex = 31;
            this.dylabel.Text = "0";
            // 
            // y2markerlabel
            // 
            this.y2markerlabel.AutoSize = true;
            this.y2markerlabel.Location = new System.Drawing.Point(27, 24);
            this.y2markerlabel.Name = "y2markerlabel";
            this.y2markerlabel.Size = new System.Drawing.Size(13, 13);
            this.y2markerlabel.TabIndex = 32;
            this.y2markerlabel.Text = "0";
            // 
            // deltayLabel
            // 
            this.deltayLabel.AutoSize = true;
            this.deltayLabel.Location = new System.Drawing.Point(70, 16);
            this.deltayLabel.Name = "deltayLabel";
            this.deltayLabel.Size = new System.Drawing.Size(21, 13);
            this.deltayLabel.TabIndex = 23;
            this.deltayLabel.Text = "dy:";
            // 
            // y1markerlabel
            // 
            this.y1markerlabel.AutoSize = true;
            this.y1markerlabel.Location = new System.Drawing.Point(27, 8);
            this.y1markerlabel.Name = "y1markerlabel";
            this.y1markerlabel.Size = new System.Drawing.Size(13, 13);
            this.y1markerlabel.TabIndex = 33;
            this.y1markerlabel.Text = "0";
            // 
            // y2Label
            // 
            this.y2Label.AutoSize = true;
            this.y2Label.Location = new System.Drawing.Point(9, 24);
            this.y2Label.Name = "y2Label";
            this.y2Label.Size = new System.Drawing.Size(21, 13);
            this.y2Label.TabIndex = 19;
            this.y2Label.Text = "y2:";
            // 
            // dxlabel
            // 
            this.dxlabel.AutoSize = true;
            this.dxlabel.Location = new System.Drawing.Point(146, 16);
            this.dxlabel.Name = "dxlabel";
            this.dxlabel.Size = new System.Drawing.Size(16, 13);
            this.dxlabel.TabIndex = 30;
            this.dxlabel.Text = "0 ";
            // 
            // y1Label
            // 
            this.y1Label.AutoSize = true;
            this.y1Label.Location = new System.Drawing.Point(9, 8);
            this.y1Label.Name = "y1Label";
            this.y1Label.Size = new System.Drawing.Size(21, 13);
            this.y1Label.TabIndex = 17;
            this.y1Label.Text = "y1:";
            // 
            // deltaxLabel
            // 
            this.deltaxLabel.AutoSize = true;
            this.deltaxLabel.Location = new System.Drawing.Point(128, 16);
            this.deltaxLabel.Name = "deltaxLabel";
            this.deltaxLabel.Size = new System.Drawing.Size(21, 13);
            this.deltaxLabel.TabIndex = 21;
            this.deltaxLabel.Text = "dx:";
            // 
            // PulseLabel
            // 
            this.PulseLabel.AutoSize = true;
            this.PulseLabel.Location = new System.Drawing.Point(185, 15);
            this.PulseLabel.Name = "PulseLabel";
            this.PulseLabel.Size = new System.Drawing.Size(85, 13);
            this.PulseLabel.TabIndex = 25;
            this.PulseLabel.Text = "Measured pulse:";
            // 
            // MeasuredPulselabel
            // 
            this.MeasuredPulselabel.AutoSize = true;
            this.MeasuredPulselabel.Location = new System.Drawing.Point(271, 15);
            this.MeasuredPulselabel.Name = "MeasuredPulselabel";
            this.MeasuredPulselabel.Size = new System.Drawing.Size(13, 13);
            this.MeasuredPulselabel.TabIndex = 27;
            this.MeasuredPulselabel.Text = "0";
            // 
            // HorizontaltrackBar
            // 
            this.HorizontaltrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HorizontaltrackBar.Location = new System.Drawing.Point(35, 476);
            this.HorizontaltrackBar.Maximum = 100;
            this.HorizontaltrackBar.Name = "HorizontaltrackBar";
            this.HorizontaltrackBar.Size = new System.Drawing.Size(822, 45);
            this.HorizontaltrackBar.TabIndex = 47;
            this.HorizontaltrackBar.Value = 50;
            this.HorizontaltrackBar.Scroll += new System.EventHandler(this.HorizontaltrackBar_Scroll);
            // 
            // VerticaltrackBar
            // 
            this.VerticaltrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticaltrackBar.Location = new System.Drawing.Point(8, 124);
            this.VerticaltrackBar.Maximum = 100;
            this.VerticaltrackBar.Name = "VerticaltrackBar";
            this.VerticaltrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VerticaltrackBar.Size = new System.Drawing.Size(45, 359);
            this.VerticaltrackBar.TabIndex = 48;
            this.VerticaltrackBar.Value = 50;
            this.VerticaltrackBar.Scroll += new System.EventHandler(this.VerticaltrackBar_Scroll);
            // 
            // MeasuredParamGroup
            // 
            this.MeasuredParamGroup.Controls.Add(this.MeasuredSaO2lable);
            this.MeasuredParamGroup.Controls.Add(this.SaO2lable);
            this.MeasuredParamGroup.Controls.Add(this.PulseLabel);
            this.MeasuredParamGroup.Controls.Add(this.y1Label);
            this.MeasuredParamGroup.Controls.Add(this.dylabel);
            this.MeasuredParamGroup.Controls.Add(this.y2Label);
            this.MeasuredParamGroup.Controls.Add(this.MeasuredPulselabel);
            this.MeasuredParamGroup.Controls.Add(this.deltayLabel);
            this.MeasuredParamGroup.Controls.Add(this.deltaxLabel);
            this.MeasuredParamGroup.Controls.Add(this.y2markerlabel);
            this.MeasuredParamGroup.Controls.Add(this.y1markerlabel);
            this.MeasuredParamGroup.Controls.Add(this.dxlabel);
            this.MeasuredParamGroup.Location = new System.Drawing.Point(474, 76);
            this.MeasuredParamGroup.Name = "MeasuredParamGroup";
            this.MeasuredParamGroup.Size = new System.Drawing.Size(370, 42);
            this.MeasuredParamGroup.TabIndex = 49;
            this.MeasuredParamGroup.TabStop = false;
            // 
            // MeasuredSaO2lable
            // 
            this.MeasuredSaO2lable.AutoSize = true;
            this.MeasuredSaO2lable.Location = new System.Drawing.Point(335, 15);
            this.MeasuredSaO2lable.Name = "MeasuredSaO2lable";
            this.MeasuredSaO2lable.Size = new System.Drawing.Size(13, 13);
            this.MeasuredSaO2lable.TabIndex = 35;
            this.MeasuredSaO2lable.Text = "0";
            // 
            // SaO2lable
            // 
            this.SaO2lable.AutoSize = true;
            this.SaO2lable.Location = new System.Drawing.Point(292, 16);
            this.SaO2lable.Name = "SaO2lable";
            this.SaO2lable.Size = new System.Drawing.Size(37, 13);
            this.SaO2lable.TabIndex = 34;
            this.SaO2lable.Text = "SaO2:";
            // 
            // signControl1
            // 
            this.signControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signControl1.BackColor = System.Drawing.Color.Black;
            this.signControl1.ForeColor = System.Drawing.Color.Black;
            this.signControl1.Location = new System.Drawing.Point(48, 137);
            this.signControl1.Name = "signControl1";
            this.signControl1.Size = new System.Drawing.Size(796, 333);
            this.signControl1.StartIndex = 0;
            this.signControl1.TabIndex = 26;
            this.signControl1.Text = "signControl1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(858, 533);
            this.Controls.Add(this.signControl1);
            this.Controls.Add(this.HorizontaltrackBar);
            this.Controls.Add(this.MeasuredParamGroup);
            this.Controls.Add(this.VerticaltrackBar);
            this.Controls.Add(this.GraphGroup);
            this.Controls.Add(this.LoggingDataGroup);
            this.Controls.Add(this.PortSettinsGroup);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pulsoximeter Analyzer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PortSettinsGroup.ResumeLayout(false);
            this.PortSettinsGroup.PerformLayout();
            this.LoggingDataGroup.ResumeLayout(false);
            this.LoggingDataGroup.PerformLayout();
            this.GraphGroup.ResumeLayout(false);
            this.GraphGroup.PerformLayout();
            this.xradiogroup.ResumeLayout(false);
            this.xradiogroup.PerformLayout();
            this.yradiogroup.ResumeLayout(false);
            this.yradiogroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontaltrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticaltrackBar)).EndInit();
            this.MeasuredParamGroup.ResumeLayout(false);
            this.MeasuredParamGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox PortSettinsGroup;
        private System.Windows.Forms.ComboBox PortConfig;
        private System.Windows.Forms.Label PortLable;
        private System.Windows.Forms.GroupBox LoggingDataGroup;
        private System.Windows.Forms.RadioButton OverwriteButton;
        private System.Windows.Forms.RadioButton AppendButton;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button btnStopGraph;
        private System.Windows.Forms.GroupBox GraphGroup;
        private System.Windows.Forms.Label y1Label;
        private System.Windows.Forms.Label y2Label;
        private System.Windows.Forms.Label deltaxLabel;
        private System.Windows.Forms.Label deltayLabel;
        private System.Windows.Forms.Label PulseLabel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.Label IsConnectedLable;
        private SignControl signControl1;
        private System.Windows.Forms.Label MeasuredPulselabel;
        private System.Windows.Forms.Label dxlabel;
        private System.Windows.Forms.Label dylabel;
        private System.Windows.Forms.Label y2markerlabel;
        private System.Windows.Forms.Label y1markerlabel;
        private System.Windows.Forms.ComboBox TimeSet;
        private System.Windows.Forms.Label KijelzohosszLabel;
        private System.Windows.Forms.CheckBox checkBoxRED_RAW;
        private System.Windows.Forms.CheckBox checkBoxIR_RAW;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button OpenNewbtn;
        private System.Windows.Forms.TextBox FilenameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenOldbtn;
        private System.Windows.Forms.Button CloseFilebtn;
        private System.Windows.Forms.TrackBar HorizontaltrackBar;
        private System.Windows.Forms.TrackBar VerticaltrackBar;
        private System.Windows.Forms.GroupBox MeasuredParamGroup;
        private System.Windows.Forms.CheckBox y2checkBox;
        private System.Windows.Forms.CheckBox y1checkBox;
        private System.Windows.Forms.CheckBox x2checkBox;
        private System.Windows.Forms.CheckBox x1checkBox;
        private System.Windows.Forms.RadioButton y1radioButton;
        private System.Windows.Forms.RadioButton y2radioButton;
        private System.Windows.Forms.RadioButton x2radioButton;
        private System.Windows.Forms.RadioButton x1radioButton;
        private System.Windows.Forms.GroupBox yradiogroup;
        private System.Windows.Forms.GroupBox xradiogroup;
        private System.Windows.Forms.Label MeasuredSaO2lable;
        private System.Windows.Forms.Label SaO2lable;
        private System.Windows.Forms.CheckBox checkBoxFILTERED;
    }
}

