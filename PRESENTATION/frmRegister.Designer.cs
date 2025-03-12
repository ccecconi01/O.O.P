
namespace _0006.ProjetoLogin.Presentation
{
    partial class frmRegister
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
            txtRegPasswd = new System.Windows.Forms.TextBox();
            txtRegLogin = new System.Windows.Forms.TextBox();
            txtRegRetypePasswd = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnRegister = new System.Windows.Forms.Button();
            btnReturn = new System.Windows.Forms.Button();
            btnmg = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtRegPasswd
            // 
            txtRegPasswd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRegPasswd.Location = new System.Drawing.Point(254, 149);
            txtRegPasswd.Name = "txtRegPasswd";
            txtRegPasswd.PasswordChar = 'X';
            txtRegPasswd.Size = new System.Drawing.Size(228, 34);
            txtRegPasswd.TabIndex = 6;
            // 
            // txtRegLogin
            // 
            txtRegLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRegLogin.Location = new System.Drawing.Point(254, 81);
            txtRegLogin.Name = "txtRegLogin";
            txtRegLogin.Size = new System.Drawing.Size(228, 34);
            txtRegLogin.TabIndex = 5;
            // 
            // txtRegRetypePasswd
            // 
            txtRegRetypePasswd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRegRetypePasswd.Location = new System.Drawing.Point(254, 211);
            txtRegRetypePasswd.Name = "txtRegRetypePasswd";
            txtRegRetypePasswd.PasswordChar = 'X';
            txtRegRetypePasswd.Size = new System.Drawing.Size(228, 34);
            txtRegRetypePasswd.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(22, 149);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 32);
            label3.TabIndex = 9;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(22, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 32);
            label2.TabIndex = 8;
            label2.Text = "Login: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(22, 211);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(196, 32);
            label1.TabIndex = 10;
            label1.Text = "Retype Password:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.White;
            btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegister.ForeColor = System.Drawing.Color.BlueViolet;
            btnRegister.Location = new System.Drawing.Point(12, 281);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(168, 58);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register as customer";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new System.Drawing.Point(428, 327);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new System.Drawing.Size(168, 58);
            btnReturn.TabIndex = 11;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnmg
            // 
            btnmg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnmg.ForeColor = System.Drawing.Color.BlueViolet;
            btnmg.Location = new System.Drawing.Point(12, 345);
            btnmg.Name = "btnmg";
            btnmg.Size = new System.Drawing.Size(168, 58);
            btnmg.TabIndex = 13;
            btnmg.Text = "Register as manager";
            btnmg.UseVisualStyleBackColor = true;
            btnmg.Click += button1_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(617, 423);
            Controls.Add(btnmg);
            Controls.Add(btnRegister);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRegRetypePasswd);
            Controls.Add(txtRegPasswd);
            Controls.Add(txtRegLogin);
            Name = "frmRegister";
            Text = "frmRegister";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtRegPasswd;
        private System.Windows.Forms.TextBox txtRegLogin;
        private System.Windows.Forms.TextBox txtRegRetypePasswd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnmg;
    }
}