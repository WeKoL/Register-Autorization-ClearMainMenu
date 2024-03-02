﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        private void Exit_Button_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Back_Button_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
        }
    }
}
