using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_PZ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBkonekcija db = new DBkonekcija();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Korisnici WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", db.con);
           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Close();
                LoginStatus.loginStatus = true;
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
            }    
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
