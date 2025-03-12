namespace _0006.ProjetoLogin.Presentation
{
    partial class frmStock
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
            list = new System.Windows.Forms.Button();
            delete = new System.Windows.Forms.Button();
            update = new System.Windows.Forms.Button();
            listView = new System.Windows.Forms.ListView();
            exit = new System.Windows.Forms.Button();
            insert = new System.Windows.Forms.Button();
            statusBox = new System.Windows.Forms.TextBox();
            priceBox = new System.Windows.Forms.TextBox();
            nameBox = new System.Windows.Forms.TextBox();
            quantityBox = new System.Windows.Forms.TextBox();
            idBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // list
            // 
            list.Location = new System.Drawing.Point(41, 368);
            list.Name = "list";
            list.Size = new System.Drawing.Size(110, 55);
            list.TabIndex = 0;
            list.Text = "List all items";
            list.UseVisualStyleBackColor = true;
            list.Click += button1_Click;
            // 
            // delete
            // 
            delete.Location = new System.Drawing.Point(293, 368);
            delete.Name = "delete";
            delete.Size = new System.Drawing.Size(111, 55);
            delete.TabIndex = 1;
            delete.Text = "Delete item";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new System.Drawing.Point(431, 368);
            update.Name = "update";
            update.Size = new System.Drawing.Size(111, 55);
            update.TabIndex = 2;
            update.Text = "Update item";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // listView
            // 
            listView.HideSelection = false;
            listView.Location = new System.Drawing.Point(41, 39);
            listView.Name = "listView";
            listView.Size = new System.Drawing.Size(501, 292);
            listView.TabIndex = 3;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // exit
            // 
            exit.Location = new System.Drawing.Point(647, 368);
            exit.Name = "exit";
            exit.Size = new System.Drawing.Size(109, 55);
            exit.TabIndex = 4;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // insert
            // 
            insert.Location = new System.Drawing.Point(167, 368);
            insert.Name = "insert";
            insert.Size = new System.Drawing.Size(107, 55);
            insert.TabIndex = 5;
            insert.Text = "Insert item";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // statusBox
            // 
            statusBox.Location = new System.Drawing.Point(569, 192);
            statusBox.Name = "statusBox";
            statusBox.Size = new System.Drawing.Size(187, 27);
            statusBox.TabIndex = 6;
            statusBox.TextChanged += textBox1_TextChanged;
            // 
            // priceBox
            // 
            priceBox.Location = new System.Drawing.Point(569, 247);
            priceBox.Name = "priceBox";
            priceBox.Size = new System.Drawing.Size(187, 27);
            priceBox.TabIndex = 7;
            // 
            // nameBox
            // 
            nameBox.Location = new System.Drawing.Point(569, 76);
            nameBox.Name = "nameBox";
            nameBox.Size = new System.Drawing.Size(187, 27);
            nameBox.TabIndex = 8;
            // 
            // quantityBox
            // 
            quantityBox.Location = new System.Drawing.Point(569, 305);
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new System.Drawing.Size(187, 27);
            quantityBox.TabIndex = 9;
            // 
            // idBox
            // 
            idBox.Location = new System.Drawing.Point(569, 129);
            idBox.Name = "idBox";
            idBox.Size = new System.Drawing.Size(187, 27);
            idBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(569, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(569, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(22, 20);
            label2.TabIndex = 12;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(569, 169);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 20);
            label3.TabIndex = 13;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(569, 222);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 20);
            label4.TabIndex = 14;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(569, 282);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 20);
            label5.TabIndex = 15;
            label5.Text = "Quantity";
            // 
            // frmStock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idBox);
            Controls.Add(quantityBox);
            Controls.Add(nameBox);
            Controls.Add(priceBox);
            Controls.Add(statusBox);
            Controls.Add(insert);
            Controls.Add(exit);
            Controls.Add(listView);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(list);
            Name = "frmStock";
            Text = "Stock";
            Load += Stock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}