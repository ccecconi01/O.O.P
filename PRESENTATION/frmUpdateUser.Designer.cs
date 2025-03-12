
namespace _0006.ProjetoLogin.Presentation
{
    partial class frmUpdateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUpdate = new System.Windows.Forms.Button();
            btnReturn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtRegRetypePasswd = new System.Windows.Forms.TextBox();
            txtRegPasswd = new System.Windows.Forms.TextBox();
            txtRegLogin = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(88, 274);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(168, 58);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new System.Drawing.Point(346, 274);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new System.Drawing.Size(168, 58);
            btnReturn.TabIndex = 19;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(31, 158);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(196, 32);
            label1.TabIndex = 18;
            label1.Text = "Retype Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(31, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 32);
            label3.TabIndex = 17;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(31, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 32);
            label2.TabIndex = 16;
            label2.Text = "Login: ";
            // 
            // txtRegRetypePasswd
            // 
            txtRegRetypePasswd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRegRetypePasswd.Location = new System.Drawing.Point(263, 158);
            txtRegRetypePasswd.Name = "txtRegRetypePasswd";
            txtRegRetypePasswd.PasswordChar = 'X';
            txtRegRetypePasswd.Size = new System.Drawing.Size(228, 34);
            txtRegRetypePasswd.TabIndex = 15;
            // 
            // txtRegPasswd
            // 
            txtRegPasswd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRegPasswd.Location = new System.Drawing.Point(263, 96);
            txtRegPasswd.Name = "txtRegPasswd";
            txtRegPasswd.PasswordChar = 'X';
            txtRegPasswd.Size = new System.Drawing.Size(228, 34);
            txtRegPasswd.TabIndex = 14;
            // 
            // txtRegLogin
            // 
            txtRegLogin.Enabled = false;
            txtRegLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRegLogin.Location = new System.Drawing.Point(263, 28);
            txtRegLogin.Name = "txtRegLogin";
            txtRegLogin.Size = new System.Drawing.Size(228, 34);
            txtRegLogin.TabIndex = 13;
            // 
            // frmUpdateUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(579, 381);
            Controls.Add(btnUpdate);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRegRetypePasswd);
            Controls.Add(txtRegPasswd);
            Controls.Add(txtRegLogin);
            Name = "frmUpdateUser";
            Text = "frmUpdateUser";
            Load += frmUpdateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegRetypePasswd;
        private System.Windows.Forms.TextBox txtRegPasswd;
        private System.Windows.Forms.TextBox txtRegLogin;
    }
}