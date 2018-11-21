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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            Provera();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sobe s = new Sobe();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gosti g = new Gosti();
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezervacija r = new Rezervacija();
            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transakcije t = new Transakcije();
            t.Show();
        }

        public void Provera()
        {
            List<int> id = new List<int>();
            DBkonekcija db = new DBkonekcija();

            string upit = $"SELECT ID_sobe FROM Rezervacija WHERE odlazak < '{DateTime.Now.ToShortDateString()}'";
            using (SqlCommand command = new SqlCommand(upit, db.con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                        while (reader.Read())
                        {
                            id.Add(reader.GetInt32(reader.GetOrdinal("ID_sobe")));
                        }
                }
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE Sobe SET slobodna=1 WHERE ID_sobe = @ID_sobe;"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.con;
                cmd.Parameters.Add("@ID_sobe", SqlDbType.Int);

                foreach (var item in id)
                {
                    cmd.Parameters["@ID_sobe"].Value = item;
                    cmd.ExecuteNonQuery();
                }
            }
            db.con.Close();
        }
    }
}
