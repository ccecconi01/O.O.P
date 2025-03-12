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
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _0006.ProjetoLogin.Presentation
{
    public partial class products_customer_ : Form
    {
        public products_customer_()
        {
            InitializeComponent();
        }

        private void products_customer__Load(object sender, EventArgs e)
        {

        }

        private void list_Click(object sender, EventArgs e)
        {

            // Create an array to store products from the DB
            Products[] products = new Products[0];
            Ctrl ctrl = new Ctrl();

            bool operSuccess = ctrl.getProductList(ref products);

            // Clear the ListView
            listViewProducts.Clear();

            // Add ListView headers
            listViewProducts.Columns.Add("#", 50);
            listViewProducts.Columns.Add("Name", 150);
            listViewProducts.Columns.Add("Status", 100);
            listViewProducts.Columns.Add("Price", 100);
            listViewProducts.View = View.Details;

            if (operSuccess)
            {
                if (ctrl.ctrlExist)
                {
                    // Populate the ListView with product data
                    for (int i = 0; i < products.Length; i++)
                    {
                        string index = Convert.ToString(i + 1);
                        string[] record =
                        {
                index,
                products[i].Name,
                products[i].Status,
                products[i].Price

            };

                        var listViewItem = new ListViewItem(record);
                        listViewProducts.Items.Add(listViewItem);
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

        private void addtocart_Click(object sender, EventArgs e)
        {

            if (listViewProducts.SelectedItems.Count > 0)
            {


                // Get product information from the selected item
                string productName = listViewProducts.SelectedItems[0].SubItems[1].Text;
                MessageBox.Show($"Product Selected to Cart: {productName} \n Quantity: 1");//to verify the value of  the selected product


                // Create an instance of Ctrl to call the updateproduct method
                Ctrl ctrl = new Ctrl();

                // Call the method to update product information
                bool operSuccess = ctrl.updateproductcart(productName);

            }
            else
            {
                MessageBox.Show("Please select a product to add to cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
