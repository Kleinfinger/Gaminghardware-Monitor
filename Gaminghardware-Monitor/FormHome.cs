using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GaminghardwareMonitor.Forms;

namespace GaminghardwareMonitor
{
    public partial class GaminghardwareMonitor : Form
    {
        //Fields
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
        }

        //Mehods
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(23, 50, 73);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(21, 44, 64);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            lblTitleChildForm.Text = childForm.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(99, 209, 180));
            OpenChildForm(new FormCPUMonitor());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(99, 209, 180));

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(99, 209, 180));

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(99, 209, 180));

        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(99, 209, 180));

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
            iconCurrentChildForm.IconChar = IconChar.Home;
            lblTitleChildForm.Text = "Home";
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
