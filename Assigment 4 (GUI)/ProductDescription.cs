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
    public partial class ProductDescription : UserControl
    {
        private string product_Name;

        public string productName
        {
            get { return product_Name; }
            set { product_Name = value; lb_Namedes.Text = value; }
        }


        private int product_Number;
        public int ProductNumber
        {
            get { return product_Number; }
            set { product_Number = value; lb_NumDes.Text = Convert.ToString(value); }
        }

        private int Product_InvNum;

        public int ProductInvNum
        {
            get { return Product_InvNum; }
            set { Product_InvNum = value; lb_InvDes.Text = Convert.ToString(value); }
        }


        private string product_Type;
        public string ProductType
        {
            get { return product_Type; }
            set { product_Type = value; lb_ProdTypeDes.Text = value; }
        }

        private DateTime product_Date;
        public DateTime ProductDate
        {
            get { return product_Date; }
            set { product_Date = value; lb_DateDes.Text = Convert.ToString(value); }
        }


        private int Product_Quantity;

        public int ProductQuantity
        {
            get { return Product_Quantity; }
            set { Product_Quantity = value; lb_QuantityDes.Text = Convert.ToString(value); }
        }

        private double product_Price;

        public double ProductPrice
        {
            get { return product_Price; }
            set { product_Price = value; lb_PriceDes.Text = Convert.ToString(value); }
        }



        public ProductDescription()
        {
            InitializeComponent();
        }

    }
}
