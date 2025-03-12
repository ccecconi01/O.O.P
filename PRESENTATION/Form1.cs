using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _0006.ProjetoLogin.Control;
using _0006.ProjetoLogin.Presentation;

namespace _0006.ProjetoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginName = txtLogin.Text;
            string passwd = txtPasswd.Text;

            Ctrl ctrl = new Ctrl();
            string userRole = ctrl.accessingCredentials(loginName, passwd);

            MessageBox.Show(ctrl.ctrlMessage, "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (ctrl.ctrlExist)
            {
                if (userRole == "Manager")
                {
                    Form2 frmManager = new Form2();
                    frmManager.ShowDialog();
                }
                else if (userRole == "Customer")
                {
                    customer frmCustomer =new customer();
                    frmCustomer.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(ctrl.ctrlMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //register button
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmReg = new frmRegister();
            frmReg.ShowDialog();

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtPasswd.Text != "")
                btnLogin.Enabled = true;
            else
                btnLogin.Enabled = false;
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtPasswd.Text != "")
                btnLogin.Enabled = true;
            else
                btnLogin.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //delete button
        private void button1_Click(object sender, EventArgs e)
        {

            string loginName = txtLogin.Text;
            string passwd = txtPasswd.Text;

            Ctrl ctrl = new Ctrl();
            bool opersuccess = ctrl.credentialsDelete(loginName, passwd);

            if (opersuccess)
            {
                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear input fields
                txtLogin.Clear();
                txtPasswd.Clear();
            }
            else
            {
                MessageBox.Show(ctrl.ctrlMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //update button connects to form update user once clicked
        private void button2_Click(object sender, EventArgs e)
        {
            frmUpdateUser frmUpdateUser = new frmUpdateUser();
            frmUpdateUser.ShowDialog();

        }
    }
}
