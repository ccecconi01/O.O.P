namespace _0006.ProjetoLogin.Presentation
{
    partial class FormStaff
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
            buttonInsert = new System.Windows.Forms.Button();
            buttonUpdate = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonBack = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxAge = new System.Windows.Forms.TextBox();
            textBoxID = new System.Windows.Forms.TextBox();
            textBoxPosition = new System.Windows.Forms.TextBox();
            listViewStaff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)listViewStaff).BeginInit();
            SuspendLayout();
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new System.Drawing.Point(563, 588);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new System.Drawing.Size(188, 58);
            buttonInsert.TabIndex = 0;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(816, 588);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(188, 58);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(1070, 588);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(188, 58);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new System.Drawing.Point(1326, 588);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(188, 58);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(52, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 41);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(52, 203);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 41);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(52, 350);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 41);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(52, 499);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 41);
            label4.TabIndex = 7;
            label4.Text = "Position";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(62, 114);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(250, 47);
            textBoxName.TabIndex = 8;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new System.Drawing.Point(62, 261);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new System.Drawing.Size(250, 47);
            textBoxAge.TabIndex = 9;
            // 
            // textBoxID
            // 
            textBoxID.Location = new System.Drawing.Point(62, 411);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new System.Drawing.Size(250, 47);
            textBoxID.TabIndex = 10;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new System.Drawing.Point(62, 554);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new System.Drawing.Size(250, 47);
            textBoxPosition.TabIndex = 11;
            // 
            // listViewStaff
            // 
            listViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listViewStaff.Location = new System.Drawing.Point(563, 114);
            listViewStaff.Name = "listViewStaff";
            listViewStaff.RowHeadersWidth = 102;
            listViewStaff.RowTemplate.Height = 49;
            listViewStaff.Size = new System.Drawing.Size(951, 414);
            listViewStaff.TabIndex = 12;
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1585, 726);
            Controls.Add(listViewStaff);
            Controls.Add(textBoxPosition);
            Controls.Add(textBoxID);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBack);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Name = "FormStaff";
            Text = "FormStaff";
            Load += FormStaff_Load_1;
            ((System.ComponentModel.ISupportInitialize)listViewStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.DataGridView listViewStaff;
    }
}