namespace Lab02
{
    partial class Lab02_Bai6
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
            this.treeview = new System.Windows.Forms.TreeView();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // treeview
            // 
            this.treeview.Location = new System.Drawing.Point(12, 12);
            this.treeview.Name = "treeview";
            this.treeview.Size = new System.Drawing.Size(271, 651);
            this.treeview.TabIndex = 0;
            this.treeview.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeview_BeforeCollapse);
            this.treeview.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeview_BeforeExpand);
            this.treeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview_AfterSelect);
            // 
            // ptb
            // 
            this.ptb.Location = new System.Drawing.Point(304, 12);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(765, 651);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb.TabIndex = 1;
            this.ptb.TabStop = false;
            // 
            // flp
            // 
            this.flp.Location = new System.Drawing.Point(12, 678);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(1057, 100);
            this.flp.TabIndex = 2;
            // 
            // Lab02_Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 790);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.ptb);
            this.Controls.Add(this.treeview);
            this.Name = "Lab02_Bai6";
            this.Text = "Lab02_Bai6";
            this.Load += new System.EventHandler(this.Lab02_Bai6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeview;
        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.FlowLayoutPanel flp;
    }
}