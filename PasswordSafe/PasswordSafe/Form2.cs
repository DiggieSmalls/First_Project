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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "password_safeDataSet.PasswordSafe". Sie können sie bei Bedarf verschieben oder entfernen.
            this.passwordSafeTableAdapter.Fill(this.password_safeDataSet.PasswordSafe);

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
