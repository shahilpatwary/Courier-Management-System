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
    public partial class EmpHomeForm : Form
    {
        public EmpHomeForm()
        {
            InitializeComponent();
        }

        private void EmpLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblVerifyCustomer_Click(object sender, EventArgs e)
        {
            //DataTable customersTable = dataAccess.GetData<Customers>($"where Is_verified = '{false}'");
           // EmpShowForm es = new EmpShowForm(usersTable, customersTable, (int)Entities.Show.EmployeeShow.varifyCustomers);
           // es.Show();
           // this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
           // LoginForm logout = new LoginForm();
          //  logout.Show();
          //  this.Hide();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
          //  EmpEditForm edit = new EmpEditForm(usersTable);
         //   edit.Show();
           // this.Hide();
        }

        private void lblServiceHistory_Click(object sender, EventArgs e)
        {
          //  EmpShowForm es = new EmpShowForm(usersTable, productsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
          //  es.Show();
          //  this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
       //     EmpProfile profile = new EmpProfile(usersTable);
         //   profile.Show();
          //  this.Hide();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblViewCustomers_Click(object sender, EventArgs e)
        {
          //  DataTable customersTable = dataAccess.GetData<Customers>($"where Is_verified = '{true}'");
          //  EmpShowForm sh = new EmpShowForm(usersTable, customersTable, (int)Entities.Show.EmployeeShow.viewCustomers);
          //  sh.Show();
          //  this.Hide();
        }

        private void lblReceiveOrder_Click(object sender, EventArgs e)
        {
           // Receive();
        }

        private void lblAddCustomers_Click(object sender, EventArgs e)
        {
            //addCUst();
        }

        private void lblReleaseOrder_Click(object sender, EventArgs e)
        {
          //  DataTable productsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Product.ProductStateEnum.Sent_to_destination}' and Receiving_B_id = '{EmployeeTable.Rows[0].Field<int>("Branch_id")}'");
           // if (productsTable.Rows.Count > 0)
         //   {
            //    EmpShowForm es = new EmpShowForm(usersTable, productsTable, (int)Entities.Show.EmployeeShow.releasedOrders);
            //    es.Show();
            //    this.Hide();
          //  }
          //  else
          //  {
          //      MessageBox.Show("No Product to ship");
          //  }
        }

        private void lblShipOrder_Click(object sender, EventArgs e)
        {
           // DataTable productsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Product.ProductStateEnum.Received}' and Sending_B_id = '{EmployeeTable.Rows[0].Field<int>("Branch_id")}'");
           // if (productsTable.Rows.Count > 0)
          //  {
             //   EmpShowForm es = new EmpShowForm(usersTable, productsTable, (int)Entities.Show.EmployeeShow.shippedOrders);
            //    es.Show();
            //    this.Hide();
          //  }
          //  else
           // {
           //     MessageBox.Show("No Product to ship");
          //  }
        }

        private void lblTermCondition_Click(object sender, EventArgs e)
        {
           // terms();
        }

        private void lblHelpLine_Click(object sender, EventArgs e)
        {
           // helpline();
        }
    }
}
