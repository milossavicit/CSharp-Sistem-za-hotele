using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_PZ
{
    public partial class Sobe : Form
    {
        public Sobe()
        {
            InitializeComponent();
        }

        private void Sobe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Sobe' table. You can move, or remove it, as needed.
            this.sobeTableAdapter.Fill(this.bazaDataSet.Sobe);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sobeBindingSource.EndEdit();
                this.sobeTableAdapter.Update(this.bazaDataSet);
                MessageBox.Show("Baza je uspešno ažurirana.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
