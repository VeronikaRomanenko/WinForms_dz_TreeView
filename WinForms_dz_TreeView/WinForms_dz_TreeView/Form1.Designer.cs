namespace WinForms_dz_TreeView
{
    partial class Form1
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
            this.txbAdres = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lsbSoderschimoe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbAdres
            // 
            this.txbAdres.Location = new System.Drawing.Point(12, 12);
            this.txbAdres.Name = "txbAdres";
            this.txbAdres.Size = new System.Drawing.Size(384, 20);
            this.txbAdres.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 50);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(384, 160);
            this.treeView1.TabIndex = 3;
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            // 
            // lsbSoderschimoe
            // 
            this.lsbSoderschimoe.FormattingEnabled = true;
            this.lsbSoderschimoe.Location = new System.Drawing.Point(11, 216);
            this.lsbSoderschimoe.Name = "lsbSoderschimoe";
            this.lsbSoderschimoe.Size = new System.Drawing.Size(385, 173);
            this.lsbSoderschimoe.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 398);
            this.Controls.Add(this.lsbSoderschimoe);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txbAdres);
            this.Name = "Form1";
            this.Text = "Проводник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAdres;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lsbSoderschimoe;
    }
}

