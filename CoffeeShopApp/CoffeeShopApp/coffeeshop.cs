using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class coffeeshop : Form
    {
        public coffeeshop()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string name;
            string contact;
            string address;
            string order;
            string quantity;
            string rich;
            rich = showRichTextBox.Text;

            name = nameTextBox.Text;
            contact = contactTextBox.Text;
            address = addressTextBox.Text;
            order = orderComboBox.Text;
            quantity = quantityTextBox.Text;

            if (name == "" || contact == "" || address == "" || order == "" || order== "")
            {

                MessageBox.Show("Please Fill Up The Form Properly!!!!!");
            }
            else
            {
                MessageBox.Show("Name: " + name + "\n" + "Contact No: " + contact + "\n" + "Address: " + address + "\n" + "Order: " + order + "\n" + "Quantity: " + quantity);
                

            }
            
        }
    }
}
