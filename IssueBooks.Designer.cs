namespace DigitalLibrary
{
    partial class IssueBooks
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
            this.lblIssueBooks = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblAuthorOfbook = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnIssueEdit = new System.Windows.Forms.Button();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnIssueDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIssueBooks
            // 
            this.lblIssueBooks.AutoSize = true;
            this.lblIssueBooks.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueBooks.Location = new System.Drawing.Point(298, 34);
            this.lblIssueBooks.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblIssueBooks.Name = "lblIssueBooks";
            this.lblIssueBooks.Size = new System.Drawing.Size(246, 36);
            this.lblIssueBooks.TabIndex = 0;
            this.lblIssueBooks.Text = "ISSUE BOOKS";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(177, 101);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(85, 16);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID";
            this.lblStudentID.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // lblAuthorOfbook
            // 
            this.lblAuthorOfbook.AutoSize = true;
            this.lblAuthorOfbook.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorOfbook.Location = new System.Drawing.Point(173, 299);
            this.lblAuthorOfbook.Name = "lblAuthorOfbook";
            this.lblAuthorOfbook.Size = new System.Drawing.Size(115, 16);
            this.lblAuthorOfbook.TabIndex = 2;
            this.lblAuthorOfbook.Text = "Author of Book";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(177, 251);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Book Title";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(177, 203);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(64, 16);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Book ID";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(177, 146);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(111, 16);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Student Name";
            this.lblname.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(317, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 27);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(317, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 27);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(317, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 27);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(317, 242);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 27);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(317, 290);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 27);
            this.textBox5.TabIndex = 10;
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(222, 400);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(85, 33);
            this.btnIssue.TabIndex = 11;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnIssueEdit
            // 
            this.btnIssueEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueEdit.Location = new System.Drawing.Point(363, 400);
            this.btnIssueEdit.Name = "btnIssueEdit";
            this.btnIssueEdit.Size = new System.Drawing.Size(79, 33);
            this.btnIssueEdit.TabIndex = 13;
            this.btnIssueEdit.Text = "Edit";
            this.btnIssueEdit.UseVisualStyleBackColor = true;
            this.btnIssueEdit.Click += new System.EventHandler(this.btnIssueEdit_Click);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(173, 347);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(85, 16);
            this.lblIssueDate.TabIndex = 14;
            this.lblIssueDate.Text = "Issue date";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(317, 338);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 27);
            this.textBox6.TabIndex = 15;
            // 
            // btnIssueDelete
            // 
            this.btnIssueDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueDelete.Location = new System.Drawing.Point(497, 400);
            this.btnIssueDelete.Name = "btnIssueDelete";
            this.btnIssueDelete.Size = new System.Drawing.Size(79, 33);
            this.btnIssueDelete.TabIndex = 16;
            this.btnIssueDelete.Text = "Delete";
            this.btnIssueDelete.UseVisualStyleBackColor = true;
            this.btnIssueDelete.Click += new System.EventHandler(this.btnIssueDelete_Click);
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnIssueDelete);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.btnIssueEdit);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthorOfbook);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblIssueBooks);
            this.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "IssueBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBooks";
            this.Load += new System.EventHandler(this.IssueBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIssueBooks;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblAuthorOfbook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnIssueEdit;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnIssueDelete;
    }
}