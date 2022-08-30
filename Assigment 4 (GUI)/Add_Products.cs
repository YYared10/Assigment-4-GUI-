using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assigment_4__GUI_
{
    public partial class Add_Products : Form
    {
        public Add_Products()
        {
            InitializeComponent();
            CurrentUser.Text += Name;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Model it = new Model();
            Regex A = new Regex(@"^[a-z]||[A-Z] {10}$");
            Regex B = new Regex(@"^[0-9]{5}$");
            bool allFieldsAreCorrect = true;
            errorProvider1.Clear();




            it.Date = dateTimePicker1.Value;



            if (B.IsMatch(txtNUM.Text))
            {

               it.Number = int.Parse(txtNUM.Text);
            }
            else
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(txtNUM, "The filed should be 5 digite whole number.");
            }

            if (B.IsMatch(txtCOUNT.Text))
            {
                it.Count = int.Parse(txtCOUNT.Text);

            }
            else
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(txtCOUNT, "The filed should be 5 digite whole number.");
            }


            if (A.IsMatch(txtOBJNM.Text))
            {
                it.Objectname = txtOBJNM.Text;
            }
            else
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(txtOBJNM, "The field should contain number.");
            }


            if (B.IsMatch(txtINVENTORYNUM.Text))
            {
                it.Inventorynum = int.Parse(txtINVENTORYNUM.Text);

            }
            else
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(txtINVENTORYNUM, "The field should be 6 digite whole number.");
            }

            try
            {
                if (string.IsNullOrEmpty(txtPRICE.Text))
                {

                    errorProvider1.SetError(txtPRICE, "The field should contain number(it can be decimal number).");
                }
                else if (B.IsMatch(txtPRICE.Text))
                {
                    it.Price = double.Parse(txtPRICE.Text);

                }
                else
                {
                    errorProvider1.Clear();
                    it.save();
                    MessageBox.Show("Sucessfully Added");
                    AllprodDGV.DataSource = null;
                    AllprodDGV.DataSource = Model.GetAllProducts();
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
                AllprodDGV.DataSource = null;
                AllprodDGV.DataSource = Model.GetAllProducts();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }


      

        private void Form1_Load(object sender, EventArgs e)
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
    }
       
}
