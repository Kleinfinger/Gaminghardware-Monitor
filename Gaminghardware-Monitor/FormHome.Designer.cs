namespace GaminghardwareMonitor
{
    partial class GaminghardwareMonitor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCPU = new System.Windows.Forms.Button();
            this.panelHead = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.buttonCPU);
            this.panelMenu.Controls.Add(this.panelHead);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 684);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonCPU
            // 
            this.buttonCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCPU.FlatAppearance.BorderSize = 0;
            this.buttonCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCPU.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F);
            this.buttonCPU.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCPU.Image = global::GaminghardwareMonitor.Properties.Resources.cpu_v2_60x60;
            this.buttonCPU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCPU.Location = new System.Drawing.Point(0, 120);
            this.buttonCPU.Name = "buttonCPU";
            this.buttonCPU.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.buttonCPU.Size = new System.Drawing.Size(220, 85);
            this.buttonCPU.TabIndex = 6;
            this.buttonCPU.Text = "CPU Monitor";
            this.buttonCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCPU.UseVisualStyleBackColor = true;
            this.buttonCPU.Click += new System.EventHandler(this.buttonCPU_Click);
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.panelHead.Controls.Add(this.buttonHome);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(220, 120);
            this.panelHead.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHome.Image = global::GaminghardwareMonitor.Properties.Resources.GHM_v2_120x120;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(220, 120);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            this.buttonHome.MouseLeave += new System.EventHandler(this.iconButtonHome_MouseLeave);
            this.buttonHome.MouseHover += new System.EventHandler(this.iconButtonHome_MouseHover);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(984, 684);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // GaminghardwareMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 684);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Name = "GaminghardwareMonitor";
            this.Text = "Gaminghardware-Monitor";
            this.panelMenu.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonCPU;
        private System.Windows.Forms.PictureBox buttonHome;
    }
}

