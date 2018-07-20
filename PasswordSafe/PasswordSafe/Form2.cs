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

namespace PasswordSafe
{
    public partial class Form2 : Form
    {

        string cs = "Data Source=.;Initial Catalog=Password_safe;Trusted_Connection = True";
        SqlConnection sqlConnection;
        SqlDataAdapter adapter;
        DataTable DataTable;



        public Form2()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "password_safeDataSet.PasswordSafe". Sie können sie bei Bedarf verschieben oder entfernen.
            this.passwordSafeTableAdapter.Fill(this.password_safeDataSet.PasswordSafe);

            


            sqlConnection = new SqlConnection(cs);
            sqlConnection.Open();
            adapter = new SqlDataAdapter("select * from PasswordSafe", sqlConnection);
            DataTable = new DataTable();
            adapter.Fill(DataTable);
            dataGridView2.DataSource = DataTable;
            sqlConnection.Close();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            sqlConnection = new SqlConnection(cs);
            sqlConnection.Open();
            adapter = new SqlDataAdapter("select * from PasswordSafe where Service like '" + textBox1.Text + "%'", sqlConnection);
            DataTable = new DataTable();
            adapter.Fill(DataTable);
            dataGridView2.DataSource = DataTable;
            sqlConnection.Close();


        }



        private void NewEntrybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Öffnet das Form2 Fenster
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
        }

        private void CloseSafebutton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            
        }

       
    }
}
