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
    public partial class Directory : Form
    {
        public Directory()
        {
            InitializeComponent();
        }

        private void Add_bttn_Click(object sender, EventArgs e)
        {
            PNL_m.BackColor = Color.Aquamarine;
            Indicator_panl.Location = new Point(Indicator_panl.Location.X, 52);
            
            if (this.flwLytPnl_productlist.Controls.Count > 0)
                this.flwLytPnl_productlist.Controls.RemoveAt(0);

            PNL_m.BackColor = Color.Coral;
            Add_Products product = new Add_Products();
            product.TopLevel = false;
            this.flwLytPnl_productlist.Controls.Add(product);
            this.flwLytPnl_productlist.Tag = product;
            product.Show();

        }

        private void Update_bttn_Click(object sender, EventArgs e)
        {
            PNL_m.BackColor = Color.DarkOliveGreen;
            Indicator_panl.Location = new Point(Indicator_panl.Location.X, 106);
        }

        private void Delete_bttn_Click(object sender, EventArgs e)
        {
            PNL_m.BackColor = Color.Red;
            Indicator_panl.Location = new Point(Indicator_panl.Location.X, 164);
            foreach (var item in Model.GetAllProducts())
            {
                Delete_product card = new Delete_product();
                card.Product = item.Objectname;
                card.ProductInvNum = item.Inventorynum;
                card.ProductQuantity = item.Count;
                card.ProductPrice = item.Price;
                card.Show();
                flwLytPnl_productlist.Controls.Add(card);

                card.DeleteButton.Click += (object o, EventArgs ee) =>
                {
                    DialogResult dialogResult = MessageBox.Show($"Action cant be undone. Do you wish to proceed?\n\n" +
                        $"\t\tDelete {item.Objectname}?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int num = Model.DeleteProduct(item.Number, item.Objectname);
                        if (num > 0)
                        {
                            MessageBox.Show($"Product {item.Objectname} has been deleted!");
                        }
                        else
                        {
                            MessageBox.Show($"Product {item.Objectname} was not deleted!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }


                };




            }
        }

        private void Exit_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Directory_Load(object sender, EventArgs e)
        {
            if (this.flwLytPnl_productlist.Controls.Count > 0)
                this.flwLytPnl_productlist.Controls.RemoveAt(0);

            foreach (var item in Model.GetAllProducts())
            {
                Poduct_Card card = new Poduct_Card();
                card.Productname = item.Objectname;
                card.ProductDescription = item.Count;
                card.ProductPrice = item.Price;
                flwLytPnl_productlist.Controls.Add(card);
                card.Show();
            }
        }

        private void flwLytPnl_productlist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttn_productlist_Click(object sender, EventArgs e)
        {

           

            PNL_m.BackColor = Color.CadetBlue;
            Indicator_panl.Location = new Point(Indicator_panl.Location.X, 271);


            foreach (var item in Model.GetAllProducts())
            {
                Poduct_Card card = new Poduct_Card();
                card.Productname = item.Objectname;
                card.ProductDescription = item.Count;
                card.ProductPrice = item.Price;
                flwLytPnl_productlist.Controls.Add(card);
                card.Show();

                card.DoubleClick += (object sender1, EventArgs ee) =>
                {
                    this.flwLytPnl_productlist.Controls.Clear();

                    ProductDescription description = new ProductDescription();
                    description.productName = item.Objectname;
                    description.ProductNumber = item.Number;
                    description.ProductInvNum = item.Inventorynum;
                    description.ProductDate = item.Date;
                    description.ProductType = item.ProductType;
                    description.ProductQuantity = item.Count;
                    description.ProductPrice = item.Price;
                    description.Show();
                    flwLytPnl_productlist.Controls.Add(description);

                };
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bttn_connectioncheck_Click(object sender, EventArgs e)
        {
            Connection_check Check = new Connection_check();
            Check.TopLevel = false;
            this.flwLytPnl_productlist.Controls.Add(Check);
            this.flwLytPnl_productlist.Tag = Check;
            Check.Show();
        }
    }
}

