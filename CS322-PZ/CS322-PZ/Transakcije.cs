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
    public partial class Transakcije : Form
    {
        public Transakcije()
        {
            InitializeComponent();
        }

        private void Prikaz()
        {
            DBkonekcija db = new DBkonekcija();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT t.*, Gosti.Ime FROM Transakcije t INNER JOIN Rezervacija r ON t.ID_rezervacije=r.ID_rezervacije INNER JOIN Gosti ON r.ID_gosta=Gosti.ID_gosta;", db.con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID tran.";
            dataGridView1.Columns[1].HeaderText = "ID rez.";
            dataGridView1.Columns[2].HeaderText = "Iznos";
            dataGridView1.Columns[3].HeaderText = "Način plaćanja";
            dataGridView1.Columns[4].HeaderText = "Datum";
            dataGridView1.Columns[5].HeaderText = "Tip kartice";
            dataGridView1.Columns[6].HeaderText = "Važi do";
            dataGridView1.Columns[7].HeaderText = "CVV";
            dataGridView1.Columns[8].HeaderText = "Br. kartice";
            dataGridView1.Columns[9].HeaderText = "Status";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            db.con.Close();
        }

        private void Transakcije_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Gotovina");
            comboBox1.Items.Add("Kartica");

            comboBox2.Items.Add("Visa");
            comboBox2.Items.Add("MasterCard");
            comboBox2.Items.Add("American Express");
            Prikaz();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                iD_transakcijeTextBox.Text = row.Cells[0].Value.ToString();
                iD_rezervacijeTextBox.Text = row.Cells[1].Value.ToString();
                iznosTextBox.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                datumDateTimePicker.Text = row.Cells[4].Value.ToString();
                comboBox2.Text = row.Cells[5].Value.ToString();
                vazi_doTextBox.Text = row.Cells[6].Value.ToString();
                cvvTextBox.Text = row.Cells[7].Value.ToString();
                br_karticeTextBox.Text = row.Cells[8].Value.ToString();

                string status = row.Cells[9].Value.ToString();
                if(status == "True")
                {
                    statusCheckBox.Checked = true;
                }
                else
                {
                    statusCheckBox.Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBkonekcija db = new DBkonekcija();
            using (SqlCommand cmd = new SqlCommand("UPDATE Transakcije SET nacin_placanja=@nacin_placanja, datum=@datum, tip_kartice=@tip_kartice," +
                "vazi_do=@vazi_do, cvv=@cvv, br_kartice=@br_kartice, status=@status WHERE ID_Transakcije=@ID_transakcije;"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.con;

                cmd.Parameters.AddWithValue("@ID_Transakcije", iD_transakcijeTextBox.Text);
                cmd.Parameters.AddWithValue("@nacin_placanja", comboBox1.Text);
                cmd.Parameters.AddWithValue("@datum", datumDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@tip_kartice", comboBox2.Text);
                cmd.Parameters.AddWithValue("@vazi_do", vazi_doTextBox.Text);
                cmd.Parameters.AddWithValue("@cvv", cvvTextBox.Text);
                cmd.Parameters.AddWithValue("@br_kartice", br_karticeTextBox.Text);

                bool status = false;
                if(statusCheckBox.Checked)
                {
                    status = true;
                }
                cmd.Parameters.AddWithValue("@status", status);

                cmd.ExecuteNonQuery();
            }

            db.con.Close();
            Prikaz();
        }
    }
}
