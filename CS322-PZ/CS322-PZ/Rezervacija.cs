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
    public partial class Rezervacija : Form
    {
        public Rezervacija()
        {
            InitializeComponent();
        }

        private void Rezervacije_Load(object sender, EventArgs e)
        {
            PunjenjeComboBoxa();
            Prikaz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBkonekcija db = new DBkonekcija();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Rezervacija (br_gostiju, dolazak, odlazak, ID_gosta, ID_sobe) " +
                "VALUES (@br_gostiju, @dolazak, @odlazak, @ID_gosta, @ID_sobe); " +
                "UPDATE Sobe SET slobodna=0 WHERE ID_sobe=@ID_sobe;"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.con;

                cmd.Parameters.AddWithValue("@br_gostiju", br_gostijuTextBox.Text);
                cmd.Parameters.AddWithValue("@dolazak", dolazakDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@odlazak", odlazakDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@ID_gosta", Convert.ToInt32(iD_gostaComboBox.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@ID_sobe", comboBox2.Text);

                cmd.ExecuteNonQuery();
            }

            db.con.Close();
            Prikaz();
            Transakcija(Convert.ToInt32(comboBox2.Text));
            PunjenjeComboBoxa();
        }

        public void PunjenjeComboBoxa()
        {
            DBkonekcija db = new DBkonekcija();
            try
            {
                string upit = "SELECT * FROM Sobe WHERE slobodna = 1";
                SqlDataAdapter da = new SqlDataAdapter(upit, db.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Sobe");
                comboBox2.DisplayMember = "ID_sobe";
                comboBox2.ValueMember = "ID_sobe";
                comboBox2.DataSource = ds.Tables["Sobe"];

                string upit1 = "SELECT * FROM Gosti";
                SqlDataAdapter da1 = new SqlDataAdapter(upit1, db.con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Gosti");
                iD_gostaComboBox.DisplayMember = "Ime";
                iD_gostaComboBox.ValueMember = "ID_gosta";
                iD_gostaComboBox.DataSource = ds1.Tables["Gosti"];

                db.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške!" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBkonekcija db = new DBkonekcija();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Transakcije WHERE ID_rezervacije = @ID_rezervacije; " +
                "UPDATE Sobe SET slobodna=1 WHERE ID_sobe = @ID_sobe; " +
                "DELETE FROM Rezervacija WHERE ID_rezervacije = @ID_rezervacije"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.con;

                cmd.Parameters.AddWithValue("@ID_rezervacije", iD_rezervacijeTextBox.Text);
                cmd.Parameters.AddWithValue("@ID_sobe", comboBox2.Text);

                cmd.ExecuteNonQuery();
            }

            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }

            db.con.Close();
            PunjenjeComboBoxa();
        }

        private void Prikaz()
        {
            DBkonekcija db = new DBkonekcija();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT r.*, Gosti.Ime, s.cena FROM Rezervacija r " +
                "INNER JOIN Sobe s ON r.ID_sobe=s.ID_sobe" +
                " INNER JOIN Gosti ON r.ID_gosta=Gosti.ID_gosta;", db.con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID rez.";
            dataGridView1.Columns[1].HeaderText = "Br. gostiju";
            dataGridView1.Columns[2].HeaderText = "Dolazak";
            dataGridView1.Columns[3].HeaderText = "Odlazak";
            dataGridView1.Columns[4].HeaderText = "ID gosta";
            dataGridView1.Columns[5].HeaderText = "ID sobe";
            dataGridView1.Columns[6].HeaderText = "Ime gosta";
            dataGridView1.Columns[7].HeaderText = "Cena sobe";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            db.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                iD_rezervacijeTextBox.Text = row.Cells[0].Value.ToString();
                br_gostijuTextBox.Text = row.Cells[1].Value.ToString();
                dolazakDateTimePicker.Text = row.Cells[2].Value.ToString();
                odlazakDateTimePicker.Text = row.Cells[3].Value.ToString();
                iD_gostaComboBox.Text = row.Cells[4].Value.ToString();
                comboBox2.Text = row.Cells[5].Value.ToString();
                imeGostalabel.Text = row.Cells[6].Value.ToString();
            }
        }

        private void Transakcija(int ID_sobe)
        {
            DateTime dt;
            DateTime dt1;
            int cena;
            int ID_rez;
            DBkonekcija db = new DBkonekcija();
            using (SqlCommand cmd = new SqlCommand("SELECT dolazak FROM Rezervacija WHERE ID_sobe=" + ID_sobe))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.con;

                dt = (DateTime)cmd.ExecuteScalar();

                cmd.ExecuteNonQuery();
            }

            using (SqlCommand cmd = new SqlCommand("SELECT odlazak FROM Rezervacija WHERE ID_sobe=" + ID_sobe))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.con;

                dt1 = (DateTime)cmd.ExecuteScalar();

                cmd.ExecuteNonQuery();
            }

            using (SqlCommand cmd = new SqlCommand("SELECT cena FROM Sobe WHERE ID_sobe=" + ID_sobe))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.con;

                cena = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.ExecuteNonQuery();
            }

            using (SqlCommand cmd = new SqlCommand("SELECT ID_rezervacije FROM Rezervacija WHERE ID_sobe=" + ID_sobe))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.con;

                ID_rez = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.ExecuteNonQuery();
            }

            int dani = (dt1 - dt).Days;
            int suma = dani * cena;

            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Transakcije (ID_rezervacije, iznos) VALUES (" + ID_rez + ", " + suma + ");"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = db.con;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom upisa transakcije! " + ex.Message);
            }
        }
    }
}
