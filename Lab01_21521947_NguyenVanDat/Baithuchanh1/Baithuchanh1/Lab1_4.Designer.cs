namespace Baithuchanh1
{
    partial class Form4
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
            this.choose = new System.Windows.Forms.ComboBox();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.exchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.FormattingEnabled = true;
            this.choose.Items.AddRange(new object[] {
            "USD ",
            "EUR",
            "GBP ",
            "SGD ",
            "JPY "});
            this.choose.Location = new System.Drawing.Point(429, 87);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(191, 24);
            this.choose.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(229, 87);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(160, 22);
            this.input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số tiền cần đổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số tiền đã đổi";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(229, 268);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(160, 22);
            this.output.TabIndex = 5;
            // 
            // exchange
            // 
            this.exchange.Location = new System.Drawing.Point(117, 182);
            this.exchange.Name = "exchange";
            this.exchange.Size = new System.Drawing.Size(272, 50);
            this.exchange.TabIndex = 7;
            this.exchange.Text = "Chuyển đổi";
            this.exchange.UseVisualStyleBackColor = true;
            this.exchange.Click += new System.EventHandler(this.exchange_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exchange);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.choose);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choose;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button exchange;
    }
}