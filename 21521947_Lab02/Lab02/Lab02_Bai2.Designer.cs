namespace Lab02
{
    partial class Lab02_Bai2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.linecount = new System.Windows.Forms.TextBox();
            this.wordscount = new System.Windows.Forms.TextBox();
            this.characterscount = new System.Windows.Forms.TextBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read From File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Line Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Words Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Characters Count";
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(124, 87);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(163, 22);
            this.filename.TabIndex = 8;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(124, 133);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(163, 22);
            this.size.TabIndex = 9;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(124, 191);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(163, 22);
            this.url.TabIndex = 10;
            // 
            // linecount
            // 
            this.linecount.Location = new System.Drawing.Point(124, 246);
            this.linecount.Name = "linecount";
            this.linecount.Size = new System.Drawing.Size(163, 22);
            this.linecount.TabIndex = 11;
            // 
            // wordscount
            // 
            this.wordscount.Location = new System.Drawing.Point(124, 296);
            this.wordscount.Name = "wordscount";
            this.wordscount.Size = new System.Drawing.Size(163, 22);
            this.wordscount.TabIndex = 12;
            // 
            // characterscount
            // 
            this.characterscount.Location = new System.Drawing.Point(124, 349);
            this.characterscount.Name = "characterscount";
            this.characterscount.Size = new System.Drawing.Size(163, 22);
            this.characterscount.TabIndex = 13;
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(15, 396);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(272, 42);
            this.exitbutton.TabIndex = 14;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(354, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(401, 416);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.characterscount);
            this.Controls.Add(this.wordscount);
            this.Controls.Add(this.linecount);
            this.Controls.Add(this.url);
            this.Controls.Add(this.size);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox linecount;
        private System.Windows.Forms.TextBox wordscount;
        private System.Windows.Forms.TextBox characterscount;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}