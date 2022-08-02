using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assigment_4__GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurrentUser.Text += Name;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Regex A = new Regex(@"^[a-z]||[A-Z] {10}$");
            Regex B = new Regex(@"[0-9]{5}$");
            bool allFieldsAreCorrect = true;




            Model it = new Model
            {
                Number = txtNUM.Text,
                Inventorynum = txtINVENTORYNUM.Text,
                Objectname = txtOBJNM.Text,
                Count = txtCOUNT.Text,
                Price = txtPRICE.Text,
                Date = dateTimePicker1.Value,
                isAvailable = cbIsAvailable.Checked,

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
            catch (Exception)
            {
                MessageBox.Show("Invalid Price  ! ");
            }

            it.isAvailable = cbIsAvailable.Checked;

            if (rbSimple.Checked == false && rbvariable.Checked == false)
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(gbProductType, "One of the radio buttons should be selected.");

            }

            it.ProductType = (rbvariable.Checked == true) ? "Variable" : "Simple";

            if (allFieldsAreCorrect == true)
            {
                it.save();
                Allprod.DataSource = null;
                Allprod.DataSource = Model.GetAllProducts();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbvariable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbIsAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
