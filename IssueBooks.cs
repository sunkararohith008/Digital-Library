using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DigitalLibrary
{
    public partial class IssueBooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\owner\Documents\books.mdf;Integrated Security=True;Connect Timeout=30");
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO issue_books VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4 + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Issue book successfully!");
            con.Close();
        }

        private void btnIssueEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE issue_books SET student_name='" + textBox2.Text + "',id_of_book='" + textBox3.Text + "',title_of_book='" + textBox4.Text + "',author_of_book='" + textBox5.Text + "',issue_date='" + textBox6.Text + "' WHERE student_id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Edit information successfully!");
            con.Close();
        }

        private void btnIssueDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE issue_books WHERE student_id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete record successfully!");
            con.Close();
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
