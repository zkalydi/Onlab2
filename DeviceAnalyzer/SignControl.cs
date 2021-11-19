using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace DeviceAnalyzer
{
    public partial class SignControl : Control
    {
        public int T;
        private int n;
        public float[] RED_RAWBuffer = new float[500];
        public float[] IR_RAWBuffer = new float[500];
        public float[] RED_FILTBuffer = new float[500];
        public float[] IR_FILTBuffer = new float[500];
        public bool DrawIR_RAW;
        public bool DrawRED_RAW;
        public bool DrawFILT;
        public bool Drawx1;
        public bool Drawx2;
        public bool Drawy1;
        public bool Drawy2;
        public float x1;
        public float x2;
        public float y1;
        public float y2;
        public float y1value;
        public float y2value;
        private float min;
        private float max;
        private float minIR_RAW;
        private float maxIR_RAW;
        private float minRED_RAW;
        private float maxRED_RAW;
        private float minIR_FILT;
        private float maxIR_FILT;
        private float minRED_FILT;
        private float maxRED_FILT;
        private float delta;

        /// <summary>
        /// Constructor
        /// </summary>
        public SignControl()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.EnableNotifyMessage, true);
            InitializeComponent();
            T = 3;
            DrawIR_RAW = true;
            DrawRED_RAW = true;
            DrawFILT = false;
            Drawx1 = false;
            Drawx2 = false;
            Drawy1 = false;
            Drawy2 = false;
        }

        /// <summary>
        /// Start index in buffer for display
        /// </summary>
        public int StartIndex { get; set; }


        /// <summary>
        /// WM_PAINT message handler
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Define the pens
            Pen BackGroundMarkerPen = new Pen(Color./*Gray*/FromArgb(0, 60, 0), 1f);
            Pen signPenIR = new Pen(Color.Aqua, 3f);
            Pen signPenRED = new Pen(Color.Orange, 3f);
            Pen markerPen = new Pen(Color.Red, 2f);

            // Draw the background markers
            for (float i = 0f; i < 100f; i++)
                pe.Graphics.DrawLine(BackGroundMarkerPen, (float)this.Width / 100f * i, 0f, (float)this.Width / 100f * i, (float)this.Height);
            for (float i = 0f; i < 50f; i++)
                pe.Graphics.DrawLine(BackGroundMarkerPen, 0f, (float)this.Height / 50f * i, (float)this.Width, (float)this.Height / 50f * i);

            // Initialize X axe
            switch (T)
            {
                case 7:
                    n = 443;
                    break;
                case 6:
                    n = 380;
                    break;
                case 5:
                    n = 316;
                    break;
                case 4:
                    n = 253;
                    break;
                case 3:
                    n = 190;
                    break;
                case 2:
                    n = 127;
                    break;
                case 1:
                    n = 63;
                    break;
            }
            //n = T * 100;

            
            // Search for extreme values of last n elements
            minIR_RAW  = IR_RAWBuffer[(StartIndex + 499) % 500];
            maxIR_RAW = IR_RAWBuffer[(StartIndex + 499) % 500];
            minRED_RAW = RED_RAWBuffer[(StartIndex + 499) % 500];
            maxRED_RAW = RED_RAWBuffer[(StartIndex + 499) % 500];
            minIR_FILT = IR_FILTBuffer[(StartIndex + 499) % 500];
            maxIR_FILT = IR_FILTBuffer[(StartIndex + 499) % 500];
            minRED_FILT = RED_FILTBuffer[(StartIndex + 499) % 500];
            maxRED_FILT = RED_FILTBuffer[(StartIndex + 499) % 500];
            for (int i = 1; i < n; i++)
            {
                if (IR_RAWBuffer[(StartIndex + 499 - i) % 500] > maxIR_RAW)
                    maxIR_RAW = IR_RAWBuffer[(StartIndex + 499 - i) % 500];
                if (IR_RAWBuffer[(StartIndex + 499 - i) % 500] < minIR_RAW)
                    minIR_RAW = IR_RAWBuffer[(StartIndex + 499 - i) % 500];
                if (RED_RAWBuffer[(StartIndex + 499 - i) % 500] > maxRED_RAW)
                    maxRED_RAW = RED_RAWBuffer[(StartIndex + 499 - i) % 500];
                if (RED_RAWBuffer[(StartIndex + 499 - i) % 500] < minRED_RAW)
                    minRED_RAW = RED_RAWBuffer[(StartIndex + 499 - i) % 500];
                if (IR_FILTBuffer[(StartIndex + 499 - i) % 500] > maxIR_FILT)
                    maxIR_FILT = IR_FILTBuffer[(StartIndex + 499 - i) % 500];
                if (IR_FILTBuffer[(StartIndex + 499 - i) % 500] < minIR_FILT)
                    minIR_FILT = IR_FILTBuffer[(StartIndex + 499 - i) % 500];
                if (RED_FILTBuffer[(StartIndex + 499 - i) % 500] > maxRED_FILT)
                    maxRED_FILT = RED_FILTBuffer[(StartIndex + 499 - i) % 500];
                if (RED_FILTBuffer[(StartIndex + 499 - i) % 500] < minRED_FILT)
                    minRED_FILT = RED_FILTBuffer[(StartIndex + 499 - i) % 500];
            }

            //Initialize Y axe
            if (DrawRED_RAW && DrawIR_RAW && !DrawFILT)
            {
                max = maxIR_RAW > maxRED_RAW ? maxIR_RAW : maxRED_RAW;
                min = minIR_RAW < minRED_RAW ? minIR_RAW : minRED_RAW;
                delta = max - min == 0 ? 1 : max - min;
            }
            else if (DrawRED_RAW && !DrawIR_RAW && !DrawFILT)
            {
                max = maxRED_RAW;
                min = minRED_RAW;
                delta = max - min == 0 ? 1 : max - min;
            }
            else if (!DrawRED_RAW && DrawIR_RAW && !DrawFILT)
            {
                max = maxIR_RAW;
                min = minIR_RAW;
                delta = max - min == 0 ? 1 : max - min;
            }
            else if (!DrawRED_RAW && !DrawIR_RAW && DrawFILT)
            {
                max = maxIR_FILT > maxRED_FILT ? maxIR_FILT : maxRED_FILT;
                min = minIR_FILT < minRED_FILT ? minIR_FILT : minRED_FILT;
                delta = max - min == 0 ? 1 : max - min;
            }

            //Define Start index
            int SI = StartIndex - n >= 0 ? StartIndex - n : 500 + (StartIndex - n);

            //Draw the IR sign
            if (DrawIR_RAW)
            {
                PointF[] pointsIR = new PointF[n];
                for (int i = SI, j = 0; j < n; i = (i + 1) % 500, j++)
                {
                    pointsIR[j] = new PointF((float)this.Width / (float)n * (float)j, (float)this.Height - ((IR_RAWBuffer[i] - min) / delta * (float)this.Height));
                }
                pe.Graphics.DrawLines(signPenIR, pointsIR);
            }

            //Draw the sign RED
            if (DrawRED_RAW)
            {
                PointF[] pointsRED = new PointF[n];
                for (int i = SI, j = 0; j < n; i = (i + 1) % 500, j++)
                    pointsRED[j] = new PointF((float)this.Width / (float)(n) * (float)j, (float)this.Height - ((RED_RAWBuffer[i] - min) / delta * (float)this.Height));
                pe.Graphics.DrawLines(signPenRED, pointsRED);
            }

            // Draw the Filtered signs
            if (DrawFILT)
            {
                PointF[] pointsRED_FILT = new PointF[n];
                for (int i = SI, j = 0; j < n; i = (i + 1) % 500, j++)
                    pointsRED_FILT[j] = new PointF((float)this.Width / (float)(n) * (float)j, (float)this.Height - ((RED_FILTBuffer[i] - min) / delta * (float)this.Height));
                pe.Graphics.DrawLines(signPenRED, pointsRED_FILT);

                PointF[] pointsIR_FILT = new PointF[n];
                for (int i = SI, j = 0; j < n; i = (i + 1) % 500, j++)
                    pointsIR_FILT[j] = new PointF((float)this.Width / (float)(n) * (float)j, (float)this.Height - ((IR_FILTBuffer[i] - min) / delta * (float)this.Height));
                pe.Graphics.DrawLines(signPenIR, pointsIR_FILT);
            }

            // Draw markers
            if (Drawx1)
            {
                pe.Graphics.DrawLine(markerPen, (float)this.Width / 100 * x1, 0f, (float)this.Width / 100 * x1, (float)this.Height);
            }

            if (Drawx2)
            {
                pe.Graphics.DrawLine(markerPen, (float)this.Width / 100 * x2, 0f, (float)this.Width / 100 * x2, (float)this.Height);
            }

            if (Drawy1)
            {
                pe.Graphics.DrawLine(markerPen, 0f, (float)this.Height - (float)this.Height / 100 * y1, (float)this.Width, (float)this.Height - (float)this.Height / 100 * y1);
                y1value = delta / 100 * y1 +min;
            }
            else
            {
                y1value = 0;
            }

            if (Drawy2)
            {
                pe.Graphics.DrawLine(markerPen, 0f, (float)this.Height - (float)this.Height / 100 * y2, (float)this.Width, (float)this.Height - (float)this.Height / 100 * y2);
                y2value = delta / 100 * y2 + min;
            }
            else
            {
                y2value = 0;
            }

            base.OnPaint(pe);
        }
    }
}
