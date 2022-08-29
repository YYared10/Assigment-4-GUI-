using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assigment_4__GUI_
{
    public partial class Connection_check : Form
    {
        public Connection_check()
        {
            InitializeComponent();
        }

        private void bttn_check_Click(object sender, EventArgs e)
        {
            try
            {
                Database_Services databaseServices = new Database_Services();
                MessageBox.Show("Able to Connect");




            }
            catch (Exception )
            {
                MessageBox.Show("Unable to Open");
            }
        }
    }
}
