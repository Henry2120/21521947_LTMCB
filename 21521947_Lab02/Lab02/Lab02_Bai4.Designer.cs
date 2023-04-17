namespace Lab02
{
    partial class Lab02_Bai4
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
            this.readfilebutton = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCourse1 = new System.Windows.Forms.TextBox();
            this.txtCourse2 = new System.Windows.Forms.TextBox();
            this.txtCourse3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Writefile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readfilebutton
            // 
            this.readfilebutton.Location = new System.Drawing.Point(255, 541);
            this.readfilebutton.Name = "readfilebutton";
            this.readfilebutton.Size = new System.Drawing.Size(217, 34);
            this.readfilebutton.TabIndex = 0;
            this.readfilebutton.Text = "Ghi vào file input";
            this.readfilebutton.UseVisualStyleBackColor = true;
            this.readfilebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(310, 13);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(478, 497);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 148);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(178, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(126, 216);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(178, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // txtCourse1
            // 
            this.txtCourse1.Location = new System.Drawing.Point(126, 284);
            this.txtCourse1.Name = "txtCourse1";
            this.txtCourse1.Size = new System.Drawing.Size(178, 22);
            this.txtCourse1.TabIndex = 5;
            // 
            // txtCourse2
            // 
            this.txtCourse2.Location = new System.Drawing.Point(126, 356);
            this.txtCourse2.Name = "txtCourse2";
            this.txtCourse2.Size = new System.Drawing.Size(178, 22);
            this.txtCourse2.TabIndex = 6;
            // 
            // txtCourse3
            // 
            this.txtCourse3.Location = new System.Drawing.Point(126, 425);
            this.txtCourse3.Name = "txtCourse3";
            this.txtCourse3.Size = new System.Drawing.Size(178, 22);
            this.txtCourse3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Điểm thứ nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Điểm thứ hai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Điểm thứ ba";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(41, 541);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(105, 34);
            this.Add.TabIndex = 17;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Writefile
            // 
            this.Writefile.Location = new System.Drawing.Point(590, 541);
            this.Writefile.Name = "Writefile";
            this.Writefile.Size = new System.Drawing.Size(198, 34);
            this.Writefile.TabIndex = 18;
            this.Writefile.Text = "Xuất ra file output";
            this.Writefile.UseVisualStyleBackColor = true;
            this.Writefile.Click += new System.EventHandler(this.Writefile_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 623);
            this.Controls.Add(this.Writefile);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourse3);
            this.Controls.Add(this.txtCourse2);
            this.Controls.Add(this.txtCourse1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.readfilebutton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readfilebutton;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCourse1;
        private System.Windows.Forms.TextBox txtCourse2;
        private System.Windows.Forms.TextBox txtCourse3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Writefile;
    }
}