namespace Baithuchanh1
{
    partial class Lab1_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stn = new System.Windows.Forms.TextBox();
            this.kq = new System.Windows.Forms.TextBox();
            this.sth = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // stn
            // 
            this.stn.Location = new System.Drawing.Point(242, 90);
            this.stn.Name = "stn";
            this.stn.Size = new System.Drawing.Size(215, 22);
            this.stn.TabIndex = 3;
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(242, 272);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(215, 22);
            this.kq.TabIndex = 5;
            // 
            // sth
            // 
            this.sth.Location = new System.Drawing.Point(242, 163);
            this.sth.Name = "sth";
            this.sth.Size = new System.Drawing.Size(215, 22);
            this.sth.TabIndex = 6;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(60, 213);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(397, 23);
            this.add.TabIndex = 7;
            this.add.Text = "Tính tổng";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sth);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.stn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "label2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stn;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.TextBox sth;
        private System.Windows.Forms.Button add;
    }
}

