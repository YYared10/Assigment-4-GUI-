using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_4__GUI_
{
    public partial class Main : Form
    {
        public string email { get; set; }

        public Main()
        {
            InitializeComponent();
        }
        public Main(String email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                
            }
                Add_Products form = new Add_Products();
                form.MdiParent = this;
                form.Show();

        }

        private void SearchProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
               
            }
                Search form = new Search();
                form.MdiParent = this;
                form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
