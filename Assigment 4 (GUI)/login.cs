using System;
using System.Windows.Forms;

namespace Assigment_4__GUI_
{
    public partial class login : Form
    {
        public login()
        {

            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            string Email = textBox1Email.Text;
            string Password = textBoxpass.Text;

            if ((this.textBox1Email.Text == "Admin") && (this.textBoxpass.Text == "Admin"))
            {
                this.Hide();
                Main form = new Main(textBox1Email.Text);
                MessageBox.Show("you are granted access");
                form.Show();


            }
            else
            {
                MessageBox.Show("you are not granted  access " +
                    " input correct pass");
            }
        }

        
    }
}
