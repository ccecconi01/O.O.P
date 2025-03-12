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

namespace _0006.ProjetoLogin.Presentation
{
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        public string loginName;
        public string password;

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            txtRegLogin.Text = loginName;
            txtRegPasswd.Text = password;
            txtRegRetypePasswd.Text = password;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool operSuccess = false;

            string log = txtRegLogin.Text;
            string pwd = txtRegPasswd.Text;
            string rpwd = txtRegRetypePasswd.Text;

            Ctrl ctrl = new Ctrl();

            operSuccess = ctrl.updateVerification(log, pwd, rpwd);
            string msg = ctrl.ctrlMessage;

            MessageBox.Show (msg);
            
        }
    }
}
