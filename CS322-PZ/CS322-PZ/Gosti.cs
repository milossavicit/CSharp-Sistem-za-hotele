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
    public partial class Gosti : Form
    {
        public Gosti()
        {
            InitializeComponent();
        }

        private void Gosti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Gosti' table. You can move, or remove it, as needed.
            this.gostiTableAdapter.Fill(this.bazaDataSet.Gosti);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.gostiBindingSource.EndEdit();
                this.gostiTableAdapter.Update(this.bazaDataSet);
                MessageBox.Show("Baza je uspešno ažurirana.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DBkonekcija db = new DBkonekcija();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Gosti WHERE ID_gosta = @ID_gosta;"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.con;

                cmd.Parameters.AddWithValue("@ID_gosta", iD_gostaTextBox.Text);

                cmd.ExecuteNonQuery();
            }

            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }

            db.con.Close();
        }
    }
}
