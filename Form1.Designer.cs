namespace DigitalLibrary
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
            this.btnClickHere = new System.Windows.Forms.Button();
            this.lblClickHere = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClickHere
            // 
            this.btnClickHere.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickHere.Location = new System.Drawing.Point(38, 136);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(212, 156);
            this.btnClickHere.TabIndex = 0;
            this.btnClickHere.Text = "Click Here to view the names of Group Members";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // lblClickHere
            // 
            this.lblClickHere.AutoSize = true;
            this.lblClickHere.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickHere.Location = new System.Drawing.Point(309, 192);
            this.lblClickHere.Name = "lblClickHere";
            this.lblClickHere.Size = new System.Drawing.Size(250, 23);
            this.lblClickHere.TabIndex = 1;
            this.lblClickHere.Text = "Names of Group Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIGITAL LIBRARY MANAGEMENT APP";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookDetailsToolStripMenuItem,
            this.booToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // addBookDetailsToolStripMenuItem
            // 
            this.addBookDetailsToolStripMenuItem.Name = "addBookDetailsToolStripMenuItem";
            this.addBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBookDetailsToolStripMenuItem.Text = "Add Book Details";
            this.addBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.addBookDetailsToolStripMenuItem_Click);
            // 
            // booToolStripMenuItem
            // 
            this.booToolStripMenuItem.Name = "booToolStripMenuItem";
            this.booToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.booToolStripMenuItem.Text = "Issue Books";
            this.booToolStripMenuItem.Click += new System.EventHandler(this.booToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logToolStripMenuItem.Text = "Logout";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClickHere);
            this.Controls.Add(this.btnClickHere);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IntroductionPage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.Label lblClickHere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booToolStripMenuItem;
    }
}

