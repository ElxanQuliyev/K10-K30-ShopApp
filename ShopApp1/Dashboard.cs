using ShopApp1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp1
{
    public partial class Dashboard : Form
    {
        Customer activeCustomer { get; set; }
        public Dashboard(Customer a)
        {
            activeCustomer=a;
            InitializeComponent();
        
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = string.Format("Dear, {0} {1} Xoş gelmisiz", activeCustomer.Firstname, activeCustomer.Surname);


        }

        private void LblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
