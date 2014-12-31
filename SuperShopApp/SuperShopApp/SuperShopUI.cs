using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        public SuperShopUI()
        {
            InitializeComponent();
        }

        private Shop aShop;
        private Product aProduct;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameTextBox.Text,addressTextBox.Text);
            MessageBox.Show("Info Added");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            aProduct = new Product(productTextBox.Text,Convert.ToInt32(quantityTextBox.Text));
            string msg = aShop.Additem(aProduct);
            MessageBox.Show(msg);

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string info = "Product Id \t Quantity\n";
            foreach (Product product1 in aShop.GetProducts())
            {
                string aRow = product1.ProductId + "\t" + product1.Quantity + "\n";
                info += aRow;
            }
            MessageBox.Show(info);
        }
    }
}
