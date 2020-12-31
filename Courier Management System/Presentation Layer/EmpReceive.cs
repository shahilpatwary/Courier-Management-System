using System;
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
    public partial class EmpReceive : Form
    {
        public EmpReceive()
        {
            InitializeComponent();
        }

        private void EmpReceive_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvReceiveFromCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         //   DialogResult dialogResult = MessageBox.Show("Do you Want to Receive the product?", "Product receiving", MessageBoxButtons.YesNo);

           // action_According_Dialog_Result_1(dialogResult, e);
        }

        private void dgvReceiveFromOtherBranch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Do you Want to Receive the product?", "Product receiving", MessageBoxButtons.YesNo);

           // action_According_Dialog_Result_2(dialogResult, e);
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
          //  EmpHomeForm home = new EmpHomeForm(usersTable);
          //  home.Show();
          //  this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //EmpProfile profile = new EmpProfile(usersTable);
           // profile.Show();
           // this.Hide();
        }

        private void lblServiceHistory_Click(object sender, EventArgs e)
        {
           // EmpShowForm es = new EmpShowForm(usersTable, productsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
          //  es.Show();
           // this.Hide();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
          //  EmpEditForm edit = new EmpEditForm(usersTable);
         //   edit.Show();
         //   this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
           // LoginForm login = new LoginForm();
          //  login.Show();
          //  this.Hide();
        }
    }
}
