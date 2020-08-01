using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            lblClickHere.Text = "Arshveer uppal (200451204), Rohith Preetham Sunkara (200449343)";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void addBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetails bk = new BookDetails();
            bk.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void booToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks issue = new IssueBooks();
            issue.Show();
        }
    }
}
