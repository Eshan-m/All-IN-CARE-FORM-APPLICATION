namespace WindowsFormsApp1
{
    partial class Channel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Channel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnChannel = new System.Windows.Forms.Button();
            this.cmbSpecialize = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProbDescript = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specialize:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Hospital:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 457);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Date & Time:";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(311, 463);
            this.dtpAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(277, 22);
            this.dtpAppointment.TabIndex = 8;
            // 
            // btnChannel
            // 
            this.btnChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChannel.FlatAppearance.BorderSize = 0;
            this.btnChannel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChannel.Location = new System.Drawing.Point(709, 511);
            this.btnChannel.Margin = new System.Windows.Forms.Padding(4);
            this.btnChannel.Name = "btnChannel";
            this.btnChannel.Size = new System.Drawing.Size(272, 64);
            this.btnChannel.TabIndex = 9;
            this.btnChannel.Text = "Channel Now";
            this.btnChannel.UseVisualStyleBackColor = false;
            this.btnChannel.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSpecialize
            // 
            this.cmbSpecialize.FormattingEnabled = true;
            this.cmbSpecialize.Items.AddRange(new object[] {
            "~Problems~",
            "Cardiologists",
            "Neurologists",
            "Otolaryngologists",
            "Ophthalmologists"});
            this.cmbSpecialize.Location = new System.Drawing.Point(311, 107);
            this.cmbSpecialize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSpecialize.Name = "cmbSpecialize";
            this.cmbSpecialize.Size = new System.Drawing.Size(277, 24);
            this.cmbSpecialize.TabIndex = 10;
            this.cmbSpecialize.Tag = "";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Items.AddRange(new object[] {
            "~Doctors~",
            "Dr. Stanley Amarasekara.",
            "Dr. Deepal Attanayake",
            "Dr. Sobitha Attygalle Abeyratne",
            "Dr. Kusum Ratnayake"});
            this.cmbDoctor.Location = new System.Drawing.Point(311, 313);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(277, 24);
            this.cmbDoctor.TabIndex = 11;
            // 
            // cmbHospital
            // 
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Items.AddRange(new object[] {
            "~Hospitals~",
            "Nawaloka Hospital",
            "Lanka Hospital",
            "Durdans Hospital",
            "Hemas Hospital"});
            this.cmbHospital.Location = new System.Drawing.Point(311, 386);
            this.cmbHospital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(277, 24);
            this.cmbHospital.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 44);
            this.label3.TabIndex = 13;
            this.label3.Text = "Channel Now";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Problem Description:";
            // 
            // txtProbDescript
            // 
            this.txtProbDescript.Location = new System.Drawing.Point(311, 187);
            this.txtProbDescript.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProbDescript.Multiline = true;
            this.txtProbDescript.Name = "txtProbDescript";
            this.txtProbDescript.Size = new System.Drawing.Size(277, 98);
            this.txtProbDescript.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(24, 538);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 37);
            this.button2.TabIndex = 16;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 586);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtProbDescript);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHospital);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbSpecialize);
            this.Controls.Add(this.btnChannel);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Channel";
            this.Text = "Channel Now";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Button btnChannel;
        private System.Windows.Forms.ComboBox cmbSpecialize;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProbDescript;
        private System.Windows.Forms.Button button2;
    }
}