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
    public partial class Poduct_Card : UserControl
    {
        public Poduct_Card()
        {
            InitializeComponent();
        }

        private string _Productname;


        public string Productname
        {
            get { return _Productname; }
            set { _Productname = value; NM_label1.Text = value; }
        }

        private int _ProductDescription;

        public int ProductDescription
        {
            get { return _ProductDescription; }
            set { _ProductDescription = value; Description_lbl.Text += value; }
        }

        private double _ProductPrice;

        public double ProductPrice
        {
            get { return _ProductPrice; }
            set { _ProductPrice = value; Price_lbl.Text += value; }
        }

        private void Poduct_Card_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
