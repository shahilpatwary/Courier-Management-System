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
    public partial class EmpRegistration : Form
    {
        public EmpRegistration()
        {
            InitializeComponent();
        }

        private void EmpRegistration_Load(object sender, EventArgs e)
        {

        }

        private void EmpRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateDocument_Click(object sender, EventArgs e)
        {
           // updateDocument();
        }
    }
}
