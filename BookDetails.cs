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
    public partial class BookDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\owner\Documents\books.mdf;Integrated Security=True;Connect Timeout=30");
        public BookDetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO book_details VALUES ('"+textBox6.Text+"','"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4+"','"+textBox5.Text+"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert book details successfully!");
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE book_details SET book_title='"+textBox1.Text+"',author='"+textBox2.Text+"',category='"+textBox3.Text+"',publisher='"+textBox4.Text+"',year_of_publication='"+textBox5.Text+"' WHERE book_id='"+textBox6.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update book details successfully!");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE book_details WHERE book_id='" + textBox6.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete book details successfully!");
            con.Close();
        }
    }
}
