namespace WindowsFormsApp1
{
    partial class PRLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PharmacyLogin = new System.Windows.Forms.Button();
            this.RiderLogin = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(206, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN NOW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 11;
            // 
            // PharmacyLogin
            // 
            this.PharmacyLogin.BackColor = System.Drawing.Color.Silver;
            this.PharmacyLogin.FlatAppearance.BorderSize = 0;
            this.PharmacyLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.PharmacyLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PharmacyLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PharmacyLogin.Location = new System.Drawing.Point(135, 286);
            this.PharmacyLogin.Name = "PharmacyLogin";
            this.PharmacyLogin.Size = new System.Drawing.Size(92, 40);
            this.PharmacyLogin.TabIndex = 12;
            this.PharmacyLogin.Text = "Pharmacy\r\nLogin";
            this.PharmacyLogin.UseVisualStyleBackColor = false;
            this.PharmacyLogin.Click += new System.EventHandler(this.PharmacyLogin_Click);
            // 
            // RiderLogin
            // 
            this.RiderLogin.BackColor = System.Drawing.Color.Silver;
            this.RiderLogin.FlatAppearance.BorderSize = 0;
            this.RiderLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.RiderLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RiderLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiderLogin.Location = new System.Drawing.Point(354, 286);
            this.RiderLogin.Name = "RiderLogin";
            this.RiderLogin.Size = new System.Drawing.Size(92, 40);
            this.RiderLogin.TabIndex = 13;
            this.RiderLogin.Text = "Rider\r\nLogin";
            this.RiderLogin.UseVisualStyleBackColor = false;
            this.RiderLogin.Click += new System.EventHandler(this.RiderLogin_Click);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Transparent;
            this.SignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignUp.FlatAppearance.BorderSize = 2;
            this.SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(221, 413);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(149, 30);
            this.SignUp.TabIndex = 14;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(12, 409);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(26, 34);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PRLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 488);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.RiderLogin);
            this.Controls.Add(this.PharmacyLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PRLogin";
            this.Text = "PRLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button PharmacyLogin;
        private System.Windows.Forms.Button RiderLogin;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button BackButton;
    }
}