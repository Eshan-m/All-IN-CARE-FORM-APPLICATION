namespace WindowsFormsApp1
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PatientLogin = new System.Windows.Forms.Button();
            this.DoctorLogin = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OtherLogin = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 1;
            // 
            // PatientLogin
            // 
            this.PatientLogin.BackColor = System.Drawing.Color.Silver;
            this.PatientLogin.FlatAppearance.BorderSize = 0;
            this.PatientLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.PatientLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientLogin.Location = new System.Drawing.Point(148, 292);
            this.PatientLogin.Name = "PatientLogin";
            this.PatientLogin.Size = new System.Drawing.Size(90, 34);
            this.PatientLogin.TabIndex = 2;
            this.PatientLogin.Text = "Patient \r\nLogin";
            this.PatientLogin.UseVisualStyleBackColor = false;
            this.PatientLogin.Click += new System.EventHandler(this.PatientLogin_Click);
            // 
            // DoctorLogin
            // 
            this.DoctorLogin.BackColor = System.Drawing.Color.Silver;
            this.DoctorLogin.FlatAppearance.BorderSize = 0;
            this.DoctorLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.DoctorLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorLogin.Location = new System.Drawing.Point(322, 292);
            this.DoctorLogin.Name = "DoctorLogin";
            this.DoctorLogin.Size = new System.Drawing.Size(91, 34);
            this.DoctorLogin.TabIndex = 3;
            this.DoctorLogin.Text = " Doctor\r\nLogin";
            this.DoctorLogin.UseVisualStyleBackColor = false;
            this.DoctorLogin.Click += new System.EventHandler(this.DoctorLogin_Click);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Transparent;
            this.SignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignUp.FlatAppearance.BorderSize = 2;
            this.SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(302, 397);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(123, 34);
            this.SignUp.TabIndex = 4;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN NOW";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Black;
            this.lable1.Location = new System.Drawing.Point(174, 142);
            this.lable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(77, 15);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // OtherLogin
            // 
            this.OtherLogin.BackColor = System.Drawing.Color.Silver;
            this.OtherLogin.FlatAppearance.BorderSize = 0;
            this.OtherLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.OtherLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OtherLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherLogin.Location = new System.Drawing.Point(494, 292);
            this.OtherLogin.Name = "OtherLogin";
            this.OtherLogin.Size = new System.Drawing.Size(84, 34);
            this.OtherLogin.TabIndex = 3;
            this.OtherLogin.Text = " Other\r\nLogin";
            this.OtherLogin.UseVisualStyleBackColor = false;
            this.OtherLogin.Click += new System.EventHandler(this.OtherLogin_Click);
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(12, 398);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(26, 34);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 444);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OtherLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.DoctorLogin);
            this.Controls.Add(this.PatientLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button PatientLogin;
        private System.Windows.Forms.Button DoctorLogin;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OtherLogin;
        private System.Windows.Forms.Button BackButton;
    }
}