using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Print_Order_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxSize.Items.Add("Small");  // small size of the photo print
            cbxSize.Items.Add("Medium");  // medium size of the photo print
            cbxSize.Items.Add("Large");     // large size of the photo print 
            cbxSize.Items.Add("Extra Large");  // extra large size of the photo print

            cbxSize.SelectedIndex = 0;  // Select the first size
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtQuantity.Text, out int quantity) == false)  // if number is ture if text is false
            {
                MessageBox.Show("Quantity must be a number", "Error"); // only numbers for quantity
                return; // return statement 
            }
            if (quantity <1)  // Make sure it's positive too
            {
                MessageBox.Show("Quantity must be positive", "Error"); //must be a postive number
                return;
            }
            
            string size = cbxSize.SelectedItem.ToString(); 

            double price;

            switch (size) 
            {

                case "Small":
                    price = 0.20;  // the smallest size for the photo print
                    break;
                case "Medium":
                    price = 0.30;
                    break;
                case "Large":
                    price = 0.40;
                    break;
                case "Extra Large": // the largest size for the photo print
                    price = 0.50;
                    break;
                default:
                    MessageBox.Show("Unknow size");
                    return;  // Stop processing this event
            }
            
            double total = price * quantity; // the price is depend on what size you choose 
            txtPrice.Text = total.ToString("C");  // Format as currency
        }
    }
}
