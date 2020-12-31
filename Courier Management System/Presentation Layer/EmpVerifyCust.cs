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
    public partial class EmpVerifyCust : Form
    {
        public EmpVerifyCust()
        {
            InitializeComponent();
        }

        private void EmpVerifyCust_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
           // EmpHomeForm home = new EmpHomeForm(usersTable);
            //home.Show();
           // this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           // EmpProfile profile = new EmpProfile(usersTable);
           // profile.Show();
            //this.Hide();
        }

        private void lblServiceHistory_Click(object sender, EventArgs e)
        {
          //  EmpShowForm sh = new EmpShowForm(usersTable, productsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
          //  sh.Show();
          //  this.Hide();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
           // EmpEditForm edit = new EmpEditForm(usersTable);
           // edit.Show();
           // this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
           // LoginForm logout = new LoginForm();
          //  logout.Show();
           // this.Hide();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
          //  int rowsAffected = dataAccess.Delete("Customers", "User_Id", id.ToString());
          //  if (rowsAffected > 0)
          //  {
               // rowsAffected = dataAccess.Delete("Users", "Id", id.ToString());
              //  if (rowsAffected > 0)
              //  {
                  //  MessageBox.Show("Account Deleted Successfully");
                  //  DataTable customersTable = dataAccess.GetData<Customers>($"where Is_verified = '{false}'");
                   // EmpShowForm es = new EmpShowForm(usersTable, customersTable, (int)Entities.Show.EmployeeShow.varifyCustomers);
                   // es.Show();
                   // this.Hide();
               // }
              //  else
              //  {
                 //   MessageBox.Show("Something Went Wrong!!!");
              //  }
           // }
          //  else
           // {
              //  MessageBox.Show("Something Went Wrong!!!");
          //  }
        }

        private void btnVerifiedAccount_Click(object sender, EventArgs e)
        {
           // Customers customers = setCustomers();
          //  int rowsAffected = dataAccess.Insert<Customers>(customers, true);
          //  if (rowsAffected > 0)
          //  {
             //   MessageBox.Show("Customer Verified Successfully");
             //   this.Dispose();
             //   DataTable CustomersTable = dataAccess.GetData<Customers>($"where Is_verified = '{false}'");
            //    EmpShowForm sh = new EmpShowForm(usersTable, CustomersTable, (int)Entities.Show.EmployeeShow.varifyCustomers);
             //   sh.Show();
             //   this.Hide();
           // }
           // else
           // {
           //     MessageBox.Show("Something Went Wrong!!!");
          //  }
        }
    }
}
