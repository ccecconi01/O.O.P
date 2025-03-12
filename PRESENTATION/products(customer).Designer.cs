namespace _0006.ProjetoLogin.Presentation
{
    partial class products_customer_
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
            label1 = new System.Windows.Forms.Label();
            list = new System.Windows.Forms.Button();
            listViewProducts = new System.Windows.Forms.ListView();
            addtocart = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(125, 43);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(312, 62);
            label1.TabIndex = 2;
            label1.Text = "Our products";
            // 
            // list
            // 
            list.Location = new System.Drawing.Point(138, 818);
            list.Margin = new System.Windows.Forms.Padding(6);
            list.Name = "list";
            list.Size = new System.Drawing.Size(317, 80);
            list.TabIndex = 4;
            list.Text = "List Products";
            list.UseVisualStyleBackColor = true;
            list.Click += list_Click;
            // 
            // listViewProducts
            // 
            listViewProducts.HideSelection = false;
            listViewProducts.Location = new System.Drawing.Point(125, 131);
            listViewProducts.Margin = new System.Windows.Forms.Padding(6);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new System.Drawing.Size(1485, 640);
            listViewProducts.TabIndex = 5;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // addtocart
            // 
            addtocart.Location = new System.Drawing.Point(1005, 818);
            addtocart.Margin = new System.Windows.Forms.Padding(6);
            addtocart.Name = "addtocart";
            addtocart.Size = new System.Drawing.Size(298, 74);
            addtocart.TabIndex = 6;
            addtocart.Text = "Add to Cart";
            addtocart.UseVisualStyleBackColor = true;
            addtocart.Click += addtocart_Click;
            // 
            // products_customer_
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(1700, 922);
            Controls.Add(addtocart);
            Controls.Add(listViewProducts);
            Controls.Add(list);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "products_customer_";
            Text = "products_customer_";
            Load += products_customer__Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Button addtocart;
    }
}