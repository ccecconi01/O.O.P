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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace _0006.ProjetoLogin.Presentation
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            DisplayStaffList();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {

        }



        private void DisplayStaffList()
        {
            // Create an array to store staff from the DB
            Staff[] staffMembers = new Staff[0];
            Ctrl ctrl = new Ctrl();
            bool operSuccess = ctrl.getStaffList(ref staffMembers);

            // Clear the DataGridView
            listViewStaff.Rows.Clear();
            listViewStaff.Columns.Clear();

            // Add DataGridView columns
            listViewStaff.Columns.Add("Index", "#");
            listViewStaff.Columns.Add("StaffID", "Staff ID");
            listViewStaff.Columns.Add("Name", "Name");
            listViewStaff.Columns.Add("Age", "Age");
            listViewStaff.Columns.Add("Position", "Position");

            if (operSuccess)
            {
                if (ctrl.ctrlExist)
                {
                    // Populate the DataGridView with staff data
                    for (int i = 0; i < staffMembers.Length; i++)
                    {
                        string index = Convert.ToString(i + 1);
                        listViewStaff.Rows.Add(
                            index,
                            staffMembers[i].ID_Staff,
                            staffMembers[i].Nome_Staff,
                            staffMembers[i].Idade_Staff,
                            staffMembers[i].Cargo_Staff
                        );
                    }
                    MessageBox.Show(ctrl.ctrlMessage, "List Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ctrl.ctrlMessage, "List Staff", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show(ctrl.ctrlMessage, "List Staff", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string ID = textBoxID.Text;
            Ctrl ctrl = new Ctrl();
            bool operSuccess = ctrl.accessingStaffID(ID);//checking the existance of the login name in the DB

            // MessageBox.Show(ctrl.ctrlMessage);

            if (operSuccess) // if succeed
            {
                if (!ctrl.ctrlExist)
                {
                    // criar o registro staff na bd
                    string name = textBoxName.Text;
                    string age = textBoxAge.Text;
                    string cargo = textBoxPosition.Text;

                    operSuccess = ctrl.registStaff(name, age, ID, cargo);
                    if (operSuccess)
                    {
                        MessageBox.Show(ctrl.ctrlMessage, "Registration successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxName.Clear();
                        textBoxAge.Clear();
                        textBoxID.Clear();
                        textBoxPosition.Clear();
                        DisplayStaffList();
                        textBoxName.Focus();

                    }
                    else
                        MessageBox.Show(ctrl.ctrlMessage, "Registration failed. Please try again later", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(ctrl.ctrlMessage, "The Staff ID is already taken. Please choose a different one.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = listViewStaff.SelectedRows[0];

                // Get the Staff ID from the selected row
                string staffID = selectedRow.Cells["StaffID"].Value.ToString();

                // Create an instance of Ctrl
                Ctrl ctrl = new Ctrl();

                // Call the delete method (you need to implement this in your Ctrl class)
                bool operSuccess = ctrl.deleteStaff(staffID);

                // Check if the operation was successful
                if (operSuccess)
                {
                    MessageBox.Show("Staff member deleted successfully.", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the DataGridView
                    DisplayStaffList();
                }
                else
                {
                    MessageBox.Show(ctrl.ctrlMessage, "Deletion failed. Please try again later.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = listViewStaff.SelectedRows[0];

                // Get the Staff ID from the selected row
                string staffID = selectedRow.Cells["StaffID"].Value.ToString();
                string name = textBoxName.Text;
                string age = textBoxAge.Text;
                string position = textBoxPosition.Text;

                // Create an instance of Ctrl
                Ctrl ctrl = new Ctrl();

                // Call the delete method (you need to implement this in your Ctrl class)
                bool operSuccess = ctrl.updateStaff(name, age, staffID, position);

                // Check if the operation was successful
                if (operSuccess)
                {
                    MessageBox.Show("Staff member updateded successfully.", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the DataGridView
                    DisplayStaffList();
                }
                else
                {
                    MessageBox.Show(ctrl.ctrlMessage, "Update failed. Please try again later.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormStaff_Load_1(object sender, EventArgs e)
        {

        }
    }



    public class Staff
    {
        public string ID_Staff { get; set; }
        public string Nome_Staff { get; set; }
        public string Idade_Staff { get; set; }
        public string Cargo_Staff { get; set; }
    }




}
