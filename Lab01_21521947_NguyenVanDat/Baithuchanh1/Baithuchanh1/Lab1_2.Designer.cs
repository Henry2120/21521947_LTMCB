namespace Baithuchanh1
{
    partial class Lab1_2
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
            this.s1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.TextBox();
            this.s3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kq1 = new System.Windows.Forms.TextBox();
            this.kq2 = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(123, 124);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(113, 22);
            this.s1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số thứ ba";
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(380, 127);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(120, 22);
            this.s2.TabIndex = 4;
            // 
            // s3
            // 
            this.s3.Location = new System.Drawing.Point(641, 127);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(126, 22);
            this.s3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lớn nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số bé nhất";
            // 
            // kq1
            // 
            this.kq1.Location = new System.Drawing.Point(195, 346);
            this.kq1.Name = "kq1";
            this.kq1.Size = new System.Drawing.Size(125, 22);
            this.kq1.TabIndex = 8;
            // 
            // kq2
            // 
            this.kq2.Location = new System.Drawing.Point(582, 346);
            this.kq2.Name = "kq2";
            this.kq2.Size = new System.Drawing.Size(139, 22);
            this.kq2.TabIndex = 9;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(106, 242);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(113, 37);
            this.find.TabIndex = 10;
            this.find.Text = "Tìm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(361, 242);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 37);
            this.delete.TabIndex = 11;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(626, 242);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(126, 37);
            this.exit.TabIndex = 12;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.find);
            this.Controls.Add(this.kq2);
            this.Controls.Add(this.kq1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.TextBox s3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kq1;
        private System.Windows.Forms.TextBox kq2;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exit;
    }
}