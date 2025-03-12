using _0006.ProjetoLogin.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Net;

namespace _0006.ProjetoLogin.Presentation
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Create an array to store products from the DB
            Products[] products = new Products[0];
            Ctrl ctrl = new Ctrl();

            bool operSuccess = ctrl.getProductList(ref products);

            // Clear the ListView
            listView.Clear();

            // Add ListView headers
            listView.Columns.Add("#", 50);
            listView.Columns.Add("Name", 150);
            listView.Columns.Add("Product ID", 100);
            listView.Columns.Add("Status", 100);
            listView.Columns.Add("Price", 100);
            listView.Columns.Add("Quantity", 100);
            listView.View = View.Details;

            if (operSuccess)
            {
                if (ctrl.ctrlExist)
                {
                    // Populate the ListView with product data
                    for (int i = 0; i < products.Length; i++)
                    {
                        string index = Convert.ToString(i + 1);
                        string[] record = {
    index,                     
    products[i].Name,     
    products[i].ProductID,          
    products[i].Status,        
    products[i].Price,         
    products[i].Quantity       
};


                        var listViewItem = new ListViewItem(record);
                        listView.Items.Add(listViewItem);
                    }
                    MessageBox.Show(ctrl.ctrlMessage, "List Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ctrl.ctrlMessage, "List Products", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show(ctrl.ctrlMessage, "List Products", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bool operSucess = false;

            // Identify the product ID in a ListView record
            if (listView.SelectedItems.Count > 0)
            {
                string productID = listView.SelectedItems[0].SubItems[2].Text.Trim(); // Accessing the second column

                DialogResult result = MessageBox.Show("Do you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Ctrl ctrl = new Ctrl();
                    operSucess = ctrl.productdelete(productID);

                    if (operSucess)
                    {
                        button1_Click(sender, e); // Refresh the list
                        MessageBox.Show(ctrl.ctrlMessage, "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ctrl.ctrlMessage, "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            bool operSuccess = false;

            // Collect product details to insert
            string productName = nameBox.Text;
            string productId = idBox.Text;
            string productStatus = statusBox.Text;
            string productPrice = priceBox.Text;
            string productQuantity = quantityBox.Text;

            // Validate fields are not empty
            if (!string.IsNullOrWhiteSpace(productName) && !string.IsNullOrWhiteSpace(productId) &&
                !string.IsNullOrWhiteSpace(productStatus) && !string.IsNullOrWhiteSpace(productPrice) &&
                !string.IsNullOrWhiteSpace(productQuantity))
            {
                DialogResult result = MessageBox.Show("Do you want to insert this product?", "Insert Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Ctrl ctrl = new Ctrl();
                    operSuccess = ctrl.insertproduct(productName, productId, productStatus, productPrice, productQuantity);

                    if (operSuccess)
                    {
                        button1_Click(sender, e); // Refresh the list
                        MessageBox.Show(ctrl.ctrlMessage, "Insert Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nameBox.Clear();
                        priceBox.Clear();
                        idBox.Clear();
                        statusBox.Clear();
                        nameBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show(ctrl.ctrlMessage, "Insert Product", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Insert Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the list view
            if (listView.SelectedItems.Count > 0)
            {
              

                // Get product information from the selected item
                string productID = listView.SelectedItems[0].SubItems[2].Text.Trim();
                MessageBox.Show($"Selected Product ID: {productID}");//to verify the value of  the selected product
                string name = nameBox.Text;
                string status = statusBox.Text;
                string price = priceBox.Text;
                string quantity = quantityBox.Text;

                // Create an instance of Ctrl to call the updateproduct method
                Ctrl ctrl = new Ctrl();

                // Call the method to update product information
                bool operSuccess = ctrl.updateproduct(name, status, price, quantity, productID);

            }
            else
            {
                MessageBox.Show("Please select a product to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    public class Products
    {
        public string Name { get; set; }
        public string ProductID { get; set; }
        public string Status { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
    }
}


