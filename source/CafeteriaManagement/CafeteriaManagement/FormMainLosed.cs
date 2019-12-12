﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaManagement
{
    public partial class FormMainLosed : Form
    {
        public static event EventHandler<UserControl> FormMainLoaded;

        public FormMainLosed()
        {
            InitializeComponent();
            ucOrderNew1.BringToFront();
            
            
        }

        private void FormMain_Load(object sender, EventArgs e) => OnFormLoading(ucQueueBox1);


        private void OnFormLoading(UCQueueBox ucQueueBox1) => (FormMainLoaded as EventHandler<UserControl>)?.Invoke(this, ucQueueBox1);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(slideMenu.Width==50)
            {
                slideMenu.Visible = false;
                slideMenu.Width = 200;
                panelAnimater.ShowSync(slideMenu);

            }
            else
            {
                slideMenu.Visible = false;
                slideMenu.Width = 50;
                panelAnimater.ShowSync(slideMenu);
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

      

     

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnEdit.Height;
            ucEditMenuNew1.BringToFront();
            panelButton.Top = btnEdit.Top;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnPayment.Height;
            panelButton.Top = btnPayment.Top;
            ucOrderNew1.BringToFront();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnMusic.Height;
            panelButton.Top =btnMusic.Top;
            ucDisplayMusicNew1.BringToFront();
        }

        private void Queue_Click(object sender, EventArgs e)
        {
            panelButton.Height = Queue.Height;
            panelButton.Top =Queue.Top;
            ucQueueBox1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnEmployee.Height;
            panelButton.Top = btnEmployee.Top;
            ucEmployeeNew1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelButton.Height = btnHome.Height;
            panelButton.Top = btnHome.Top;
        }

        private void ucOrderNew1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxToSmallSize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            pictureBoxToBigSize.Visible = true;
            pictureBoxToSmallSize.Visible = false;
        }

        private void pictureBoxToBigSize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            pictureBoxToBigSize.Visible = false;
            pictureBoxToSmallSize.Visible = true;
        }
    }
}
