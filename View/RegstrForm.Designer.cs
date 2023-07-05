namespace View
{
    partial class RegstrForm
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
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.tologinform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccessCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.Location = new System.Drawing.Point(12, 139);
            this.PassBox.Multiline = true;
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(254, 44);
            this.PassBox.TabIndex = 0;
            this.PassBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(12, 58);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(254, 44);
            this.LoginBox.TabIndex = 1;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(144, 209);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(122, 52);
            this.SignUpButton.TabIndex = 2;
            this.SignUpButton.Text = "Sign up ";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // tologinform
            // 
            this.tologinform.Location = new System.Drawing.Point(144, 278);
            this.tologinform.Name = "tologinform";
            this.tologinform.Size = new System.Drawing.Size(122, 34);
            this.tologinform.TabIndex = 3;
            this.tologinform.Text = "if registered ";
            this.tologinform.UseVisualStyleBackColor = true;
            this.tologinform.Click += new System.EventHandler(this.tologinform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // AccessCheckBox
            // 
            this.AccessCheckBox.AutoSize = true;
            this.AccessCheckBox.Location = new System.Drawing.Point(15, 190);
            this.AccessCheckBox.Name = "AccessCheckBox";
            this.AccessCheckBox.Size = new System.Drawing.Size(67, 20);
            this.AccessCheckBox.TabIndex = 6;
            this.AccessCheckBox.Text = "Admin";
            this.AccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegstrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 330);
            this.Controls.Add(this.AccessCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tologinform);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.PassBox);
            this.Name = "RegstrForm";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegstrForm_Load);
            this.Leave += new System.EventHandler(this.RegstrForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button tologinform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AccessCheckBox;
    }
}