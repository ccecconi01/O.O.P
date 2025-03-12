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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)//register as a customer
        {
            string loginName = txtRegLogin.Text;
            Ctrl ctrl = new Ctrl();
            bool operSuccess = ctrl.accessingLoginName(loginName);//checking the existance of the login name in the DB

            // MessageBox.Show(ctrl.ctrlMessage);

            if (operSuccess) // if succeed
            {
                if (!ctrl.ctrlExist)
                {
                    // criar o login na BD
                    string password = txtRegPasswd.Text;
                    string retypePassword = txtRegRetypePasswd.Text;

                    operSuccess = ctrl.registCredentials(loginName, password, retypePassword, "Customer");//adding the user type in this case customer
                    if (operSuccess)
                        MessageBox.Show(ctrl.ctrlMessage, "Registration successful! You can now log in as a customer.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    else
                        MessageBox.Show(ctrl.ctrlMessage, "Registration failed. Please try again later", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(ctrl.ctrlMessage, "The login name is already taken. Please choose a different one.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//register button as a manager 
        {
            string loginName = txtRegLogin.Text;
            Ctrl ctrl = new Ctrl();
            bool operSuccess = ctrl.accessingLoginName(loginName);//checking the existance of the login name in the DB

            // MessageBox.Show(ctrl.ctrlMessage);

            if (operSuccess) // if succeed
            {
                if (!ctrl.ctrlExist)
                {
                    // criar o login na BD
                    string password = txtRegPasswd.Text;
                    string retypePassword = txtRegRetypePasswd.Text;

                    operSuccess = ctrl.registCredentials(loginName, password, retypePassword, "Manager"); //adding the user type in this case manager
                    if (operSuccess)
                        MessageBox.Show(ctrl.ctrlMessage, "Registration successful! You can now log in as a Manager.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(ctrl.ctrlMessage, "Registration failed. Please try again later", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(ctrl.ctrlMessage, "The login name is already taken. Please choose a different one.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
