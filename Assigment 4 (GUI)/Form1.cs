using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assigment_4__GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model it = new Model
            {
                Number = txtNUM.Text,
                Inventorynum = txtINVENTORYNUM.Text,
                Objectname = txtCOUNT.Text,
                Count = txtCOUNT.Text,
                Price = txtPRICE.Text,
                Date = dateTimePicker1.Value
            };
            it.save();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCOUNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPRICE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNUM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtINVENTORYNUM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOBJNM_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
