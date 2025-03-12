
namespace _0006.ProjetoLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtLogin = new System.Windows.Forms.TextBox();
            txtPasswd = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            btnRegister = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Freestyle Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(187, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(303, 95);
            label1.TabIndex = 0;
            label1.Text = "Cosmic Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(131, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 32);
            label2.TabIndex = 1;
            label2.Text = "Login: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(131, 246);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 32);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txtLogin
            // 
            txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLogin.Location = new System.Drawing.Point(288, 160);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new System.Drawing.Size(228, 34);
            txtLogin.TabIndex = 3;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtPasswd
            // 
            txtPasswd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPasswd.Location = new System.Drawing.Point(288, 244);
            txtPasswd.Name = "txtPasswd";
            txtPasswd.PasswordChar = 'X';
            txtPasswd.Size = new System.Drawing.Size(228, 34);
            txtPasswd.TabIndex = 4;
            txtPasswd.TextChanged += txtPasswd_TextChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(653, 448);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(85, 41);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Enabled = false;
            btnLogin.Location = new System.Drawing.Point(298, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(168, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(298, 364);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(168, 41);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 448);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(172, 40);
            button1.TabIndex = 8;
            button1.Text = "Delete account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 403);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(172, 38);
            button2.TabIndex = 9;
            button2.Text = "Update Account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(761, 501);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(txtPasswd);
            Controls.Add(txtLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

