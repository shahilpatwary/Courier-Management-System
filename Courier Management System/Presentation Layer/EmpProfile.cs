﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier_Management_System.Presentation_Layer
{
    public partial class EmpProfile : Form
    {
        public EmpProfile()
        {
            InitializeComponent();
        }

        private void EmpProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
           // EmpHomeForm home = new EmpHomeForm(usersTable);
         //   home.Show();
            //this.Hide();
        }

        private void lblServiceHistory_Click(object sender, EventArgs e)
        {
           // EmpShowForm es = new EmpShowForm(usersTable, productsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
          //  es.Show();
           // this.Hide();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
           // EmpEditForm edit = new EmpEditForm(usersTable);
          //  edit.Show();
           // this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
           // LoginForm logout = new LoginForm();
           // logout.Show();
           // this.Hide();
        }
    }
}