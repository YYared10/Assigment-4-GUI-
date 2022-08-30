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
    public partial class Delete_product : UserControl
    {
        public Delete_product()
        {
            InitializeComponent();
        }
        private string product_Name;

        public string Product
        {
            get { return product_Name; }
            set { product_Name = value; lb_Name.Text += value; }
        }

        private int Product_InvNum;

        public int ProductInvNum
        {
            get { return Product_InvNum; }
            set { Product_InvNum = value; lb_Invnum.Text += value; }
        }

        private int Product_Quantity;

        public int ProductQuantity
        {
            get { return Product_Quantity; }
            set { Product_Quantity = value; lb_Count.Text += value; }
        }

        private double product_Price;

        public double ProductPrice
        {
            get { return product_Price; }
            set { product_Price = value; lb_price.Text += value; }
        }

        public Button DeleteButton
        {
            get { return Bttn_Delete; }
        }

    }
}
