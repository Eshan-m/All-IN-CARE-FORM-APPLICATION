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
            this.unameTxt = new System.Windows.Forms.TextBox();
            this.pwTxt = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN NOW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // unameTxt
            // 
            this.unameTxt.Location = new System.Drawing.Point(277, 153);
            this.unameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.unameTxt.Name = "unameTxt";
            this.unameTxt.Size = new System.Drawing.Size(293, 22);
            this.unameTxt.TabIndex = 10;
            // 
            // pwTxt
            // 
            this.pwTxt.Location = new System.Drawing.Point(277, 226);
            this.pwTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.PasswordChar = '*';
            this.pwTxt.Size = new System.Drawing.Size(293, 22);
            this.pwTxt.TabIndex = 11;
            // 
            // PharmacyLogin
            // 
            this.PharmacyLogin.BackColor = System.Drawing.Color.Silver;
            this.PharmacyLogin.FlatAppearance.BorderSize = 0;
            this.PharmacyLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.PharmacyLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PharmacyLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PharmacyLogin.Location = new System.Drawing.Point(180, 352);
            this.PharmacyLogin.Margin = new System.Windows.Forms.Padding(4);
            this.PharmacyLogin.Name = "PharmacyLogin";
            this.PharmacyLogin.Size = new System.Drawing.Size(123, 49);
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
            this.RiderLogin.Location = new System.Drawing.Point(472, 352);
            this.RiderLogin.Margin = new System.Windows.Forms.Padding(4);
            this.RiderLogin.Name = "RiderLogin";
            this.RiderLogin.Size = new System.Drawing.Size(123, 49);
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
            this.SignUp.Location = new System.Drawing.Point(295, 508);
            this.SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(199, 37);
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
            this.BackButton.Location = new System.Drawing.Point(16, 503);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(35, 42);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PRLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 601);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.RiderLogin);
            this.Controls.Add(this.PharmacyLogin);
            this.Controls.Add(this.pwTxt);
            this.Controls.Add(this.unameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox unameTxt;
        private System.Windows.Forms.TextBox pwTxt;
        private System.Windows.Forms.Button PharmacyLogin;
        private System.Windows.Forms.Button RiderLogin;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button BackButton;
    }
}