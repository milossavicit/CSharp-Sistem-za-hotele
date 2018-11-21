using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_PZ
{
    class DBkonekcija
    {
        public SqlConnection con;
        public DBkonekcija()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\Baza.mdf;Integrated Security=True");
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Konekcija baze nije uspešna.\n" + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
