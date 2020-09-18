namespace GaminghardwareMonitor.Forms
{
    partial class FormCPUMonitor
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
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCPU = new System.Windows.Forms.Label();
            this.circularProgressBarCPU = new CircularProgressBar.CircularProgressBar();
            this.labelCPUP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(20, 215);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(192, 42);
            this.labelCPU.TabIndex = 0;
            this.labelCPU.Text = "CPU Usage";
            // 
            // circularProgressBarCPU
            // 
            this.circularProgressBarCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarCPU.AnimationSpeed = 500;
            this.circularProgressBarCPU.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarCPU.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.InnerMargin = 2;
            this.circularProgressBarCPU.InnerWidth = -1;
            this.circularProgressBarCPU.Location = new System.Drawing.Point(12, 12);
            this.circularProgressBarCPU.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarCPU.Name = "circularProgressBarCPU";
            this.circularProgressBarCPU.OuterColor = System.Drawing.Color.Silver;
            this.circularProgressBarCPU.OuterMargin = -25;
            this.circularProgressBarCPU.OuterWidth = 26;
            this.circularProgressBarCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(91)))), ((int)(((byte)(12)))));
            this.circularProgressBarCPU.ProgressWidth = 25;
            this.circularProgressBarCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarCPU.Size = new System.Drawing.Size(200, 200);
            this.circularProgressBarCPU.StartAngle = 270;
            this.circularProgressBarCPU.SubscriptColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarCPU.SubscriptText = "";
            this.circularProgressBarCPU.SuperscriptColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarCPU.SuperscriptText = "";
            this.circularProgressBarCPU.TabIndex = 1;
            this.circularProgressBarCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarCPU.Value = 68;
            // 
            // labelCPUP
            // 
            this.labelCPUP.AutoSize = true;
            this.labelCPUP.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUP.Location = new System.Drawing.Point(87, 98);
            this.labelCPUP.Name = "labelCPUP";
            this.labelCPUP.Size = new System.Drawing.Size(61, 42);
            this.labelCPUP.TabIndex = 2;
            this.labelCPUP.Text = "0%";
            // 
            // FormCPUMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(968, 565);
            this.Controls.Add(this.labelCPUP);
            this.Controls.Add(this.circularProgressBarCPU);
            this.Controls.Add(this.labelCPU);
            this.Name = "FormCPUMonitor";
            this.Text = "CPU Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCPU;
        private CircularProgressBar.CircularProgressBar circularProgressBarCPU;
        private System.Windows.Forms.Label labelCPUP;
    }
}