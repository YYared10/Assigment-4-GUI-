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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Searchbttn1_Click(object sender, EventArgs e)
        {
            List<Model> it = new List<Model>();
            Model product = Model.findOne(OBJNAMEtextBox1.Text);
            if (product == null)
            {
                MessageBox.Show("Product not found.", "No Result");
            }
            else
            {
                it.Add(product);
                SearchdataGridView1.DataSource = null;
                SearchdataGridView1.DataSource = it;
            }
        }
    }
}
