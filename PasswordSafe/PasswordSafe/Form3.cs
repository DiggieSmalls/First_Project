using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PasswordSafe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=localhost;initial Catalog=Password_safe;Trusted_Connection = True";
            string query = "insert into dbo.PasswordSafe(Service, Username, Password) values('"+ textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+ textBox3.Text.ToString()+"');";

            SqlConnection sqlConnection = new SqlConnection(constring);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader;
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Saved!");
                while (sqlDataReader.Read())
                {

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            sqlConnection.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Öffnet das Form2 Fenster
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Speichernbutton.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Speichernbutton.Enabled = true;
        }
    }

       
    
}
