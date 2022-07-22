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
            Regex A = new Regex(@"^[a-z]||[A-Z] {10}$");
            Regex B = new Regex(@"[0-9]{5}$");
           



            Model it = new Model
            {
                Number = txtNUM.Text,
                Inventorynum = txtINVENTORYNUM.Text,
                Objectname = txtOBJNM.Text,
                Count = txtCOUNT.Text,
                Price = txtPRICE.Text,
                Date = dateTimePicker1.Value,
     
            };
            if (string.IsNullOrEmpty(txtNUM.Text))
            {

                errorProvider1.SetError(txtNUM, "INVALID number- !  ");
            }
            else if (B.IsMatch(txtNUM.Text))
            {
                errorProvider1.SetError(txtNUM, "INVALID number- !  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(txtCOUNT.Text))
            {

                errorProvider1.SetError(txtCOUNT, "INVALID Count !  ");
            }
            else if (B.IsMatch(txtCOUNT.Text))
            {
                errorProvider1.SetError(txtCOUNT, "INVALID Count !  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(txtOBJNM.Text))
            {

                errorProvider1.SetError(txtOBJNM, "INVALID ObjectName  !  ");
            }
            else if (A.IsMatch(txtOBJNM.Text))
            {
                errorProvider1.SetError(txtOBJNM, "INVALID ObjectName !  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(txtINVENTORYNUM.Text))
            {

                errorProvider1.SetError(txtINVENTORYNUM, "INVALID InvetoryNUM  !  ");
            }
            else if (B.IsMatch(txtINVENTORYNUM.Text))
            {
                errorProvider1.SetError(txtINVENTORYNUM, "INVALID InvetoryNUM !  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            try
            {
                if (string.IsNullOrEmpty(txtPRICE.Text))
                {

                    errorProvider1.SetError(txtPRICE, "INVALID Price  ! ");
                }
                else
                {
                    errorProvider1.Clear();
                    it.save();
                    MessageBox.Show("Sucessfully Added");
                    Allprod.DataSource = null;
                    Allprod.DataSource = Model.GetAllProducts();   
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Price  ! ");
            }

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

        private void Allprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
