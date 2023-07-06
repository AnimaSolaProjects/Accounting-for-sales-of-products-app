namespace View
{
    partial class UserForm
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
            this.Products = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grain)).BeginInit();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.AllowUserToAddRows = false;
            this.Products.AllowUserToDeleteRows = false;
            this.Products.AllowUserToResizeColumns = false;
            this.Products.AllowUserToResizeRows = false;
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products.Location = new System.Drawing.Point(12, 12);
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            this.Products.RowHeadersWidth = 51;
            this.Products.RowTemplate.Height = 24;
            this.Products.Size = new System.Drawing.Size(364, 193);
            this.Products.TabIndex = 0;
            this.Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Products_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Total Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(594, 316);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(112, 37);
            this.price.TabIndex = 2;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(594, 212);
            this.amount.Multiline = true;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(112, 37);
            this.amount.TabIndex = 4;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Total Amount";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 37);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(453, 316);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 37);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "for grain";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "for product";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Grain
            // 
            this.Grain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grain.Location = new System.Drawing.Point(12, 212);
            this.Grain.Name = "Grain";
            this.Grain.ReadOnly = true;
            this.Grain.RowHeadersWidth = 51;
            this.Grain.RowTemplate.Height = 24;
            this.Grain.Size = new System.Drawing.Size(364, 193);
            this.Grain.TabIndex = 11;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 414);
            this.Controls.Add(this.Grain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Products);
            this.Name = "UserForm";
            this.Text = "UserTable";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.Leave += new System.EventHandler(this.UserForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grain;
    }
}