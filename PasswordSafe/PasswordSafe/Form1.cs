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
using System.Data.Sql;

namespace PasswordSafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Loginbutton.Enabled = false;

        }


        private void Loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = localhost; Initial Catalog = Password_safe; Integrated Security = True");

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM Login1 WHERE Username='" + textBox1.Text + "'AND Password='" + textBox2.Text + "'", sqlConnection);



            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                //Öffnet das Form2 Fenster
                Form2 fm2 = new Form2();
                fm2.ShowDialog();



            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Loginbutton.Enabled = true;
        }


       

        
    }
}
