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
    public partial class EmpHelpline : Form
    {
        public EmpHelpline()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void EmpHelpline_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
          //  EmpHomeForm home = new EmpHomeForm(usersTable);
          //  home.Show();
          //  this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
          //  EmpProfile profile = new EmpProfile(usersTable);
          //  profile.Show();
          //  this.Hide();
        }

        private void lblServiceHistory_Click(object sender, EventArgs e)
        {

          //  EmpShowForm es = new EmpShowForm(usersTable, productsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
          //  es.Show();
           // this.Hide();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
          //  EmpEditForm edit = new EmpEditForm(usersTable);
          //  edit.Show();
         //   this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
          //  LoginForm logout = new LoginForm();
          //  logout.Show();
          //  this.Hide();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
          //  if (rtbProblem.Text.Trim().Length != 0)
         //   {
         //       updateProblem();
       //     }
        //    else
        //    {
         //       MessageBox.Show("You haven't write any Complain");
       //     }
        }

        private void rtbProblem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
