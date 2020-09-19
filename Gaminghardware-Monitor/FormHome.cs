using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GaminghardwareMonitor.Forms;
using OpenHardwareMonitor.Hardware;
using WinFormAnimation;

namespace GaminghardwareMonitor
{
    public partial class GaminghardwareMonitor : Form
    {
        //Fields
        private PictureBox currentPbox;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public GaminghardwareMonitor()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 85);
            panelMenu.Controls.Add(leftBorderBtn);
            iconButtonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        //Mehods
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(48, 48, 48);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = color;
                //currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(48, 48, 48);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButtonCPU_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(234, 91, 12));
            OpenChildForm(new FormCPUMonitor());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(234, 91, 12));

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(234, 91, 12));

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(234, 91, 12));

        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(234, 91, 12));

        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
            
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void doWork()
        {
            Computer c = new Computer()
            {
                CPUEnabled = true
            };
            c.Open();

            foreach (var hardware in c.Hardware)
            {
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    hardware.Update();
                    foreach (var sensors in hardware.Sensors)
                    {
                        if (sensors.SensorType == SensorType.Temperature)
                        {
                            Console.WriteLine(sensors.Name + ": " + sensors.Value);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(doWork);
            newThread.Start();
        }

        private void iconButtonHome_MouseHover(object sender, EventArgs e)
        {
            currentPbox = (PictureBox)sender;
            currentPbox.BackColor = Color.FromArgb(57, 57, 57);
        }

        private void iconButtonHome_MouseLeave(object sender, EventArgs e)
        {
            currentPbox = (PictureBox)sender;
            currentPbox.BackColor = Color.FromArgb(48, 48, 48);
        }
    }
    
}
