﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4PH_PAGIBIG_HOUSING
{
    public partial class Ac_Manage_Record_NoSelectedUser : Form
    {
        public Ac_Manage_Record_NoSelectedUser()
        {
            InitializeComponent();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Administration_Dashboard administration_Dashboard = new Administration_Dashboard();
            administration_Dashboard.Show();
            this.Close();
        }

        private void Ac_Manage_Record_NoSelectedUser_Load(object sender, EventArgs e)
        {

        }
    }
}
