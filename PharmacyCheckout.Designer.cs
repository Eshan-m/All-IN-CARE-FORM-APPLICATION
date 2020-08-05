﻿namespace WindowsFormsApp1
{
    partial class PharmacyCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacyCheckout));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.dateCal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cashBtn = new System.Windows.Forms.RadioButton();
            this.payBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cityCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pharmacyLst = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBackH = new System.Windows.Forms.Button();
            this.btnBackP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(308, 554);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date:";
            // 
            // dateCal
            // 
            this.dateCal.Location = new System.Drawing.Point(323, 148);
            this.dateCal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateCal.Name = "dateCal";
            this.dateCal.Size = new System.Drawing.Size(356, 22);
            this.dateCal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Method:";
            // 
            // cashBtn
            // 
            this.cashBtn.AutoSize = true;
            this.cashBtn.BackColor = System.Drawing.Color.Transparent;
            this.cashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashBtn.Location = new System.Drawing.Point(323, 450);
            this.cashBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cashBtn.Name = "cashBtn";
            this.cashBtn.Size = new System.Drawing.Size(203, 29);
            this.cashBtn.TabIndex = 4;
            this.cashBtn.TabStop = true;
            this.cashBtn.Text = "Cash On Delivery";
            this.cashBtn.UseVisualStyleBackColor = false;
            this.cashBtn.CheckedChanged += new System.EventHandler(this.cashBtn_CheckedChanged);
            // 
            // payBtn
            // 
            this.payBtn.AutoSize = true;
            this.payBtn.BackColor = System.Drawing.Color.Transparent;
            this.payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.Location = new System.Drawing.Point(323, 487);
            this.payBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(118, 29);
            this.payBtn.TabIndex = 5;
            this.payBtn.TabStop = true;
            this.payBtn.Text = "Pay Now";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.CheckedChanged += new System.EventHandler(this.payBtn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 491);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Earn Reward Points";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(839, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cityCmb
            // 
            this.cityCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityCmb.FormattingEnabled = true;
            this.cityCmb.Items.AddRange(new object[] {
            "Colombo",
            "Anuradapuraya",
            "Polonnaruwa",
            "Kandy",
            "Galle"});
            this.cityCmb.Location = new System.Drawing.Point(51, 103);
            this.cityCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityCmb.Name = "cityCmb";
            this.cityCmb.Size = new System.Drawing.Size(181, 24);
            this.cityCmb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select Phamacy:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Delivery City:";
            // 
            // pharmacyLst
            // 
            this.pharmacyLst.FormattingEnabled = true;
            this.pharmacyLst.ItemHeight = 16;
            this.pharmacyLst.Items.AddRange(new object[] {
            "Union Chemist Colombo",
            "Lanka hospitals Pharmacy Colombo",
            "Sumathi Pharmacy Polonnaruwa",
            "Health Care Pharmacy Kandy",
            "Binura Pharmacy Galle"});
            this.pharmacyLst.Location = new System.Drawing.Point(51, 238);
            this.pharmacyLst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pharmacyLst.Name = "pharmacyLst";
            this.pharmacyLst.Size = new System.Drawing.Size(181, 196);
            this.pharmacyLst.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Please Select Your Delivery Area:";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(9, 502);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 42);
            this.button5.TabIndex = 17;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnBackH
            // 
            this.btnBackH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackH.FlatAppearance.BorderSize = 0;
            this.btnBackH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnBackH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackH.Location = new System.Drawing.Point(873, 478);
            this.btnBackH.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackH.Name = "btnBackH";
            this.btnBackH.Size = new System.Drawing.Size(146, 28);
            this.btnBackH.TabIndex = 18;
            this.btnBackH.Text = "Back to Home Page";
            this.btnBackH.UseVisualStyleBackColor = false;
            this.btnBackH.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBackP
            // 
            this.btnBackP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackP.FlatAppearance.BorderSize = 0;
            this.btnBackP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnBackP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackP.Location = new System.Drawing.Point(873, 517);
            this.btnBackP.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackP.Name = "btnBackP";
            this.btnBackP.Size = new System.Drawing.Size(146, 27);
            this.btnBackP.TabIndex = 19;
            this.btnBackP.Text = "Back to Patient ";
            this.btnBackP.UseVisualStyleBackColor = false;
            this.btnBackP.Click += new System.EventHandler(this.button3_Click);
            // 
            // PharmacyCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBackP);
            this.Controls.Add(this.btnBackH);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pharmacyLst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityCmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.cashBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateCal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PharmacyCheckout";
            this.Text = "Pharmacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton cashBtn;
        private System.Windows.Forms.RadioButton payBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cityCmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox pharmacyLst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBackH;
        private System.Windows.Forms.Button btnBackP;
    }
}