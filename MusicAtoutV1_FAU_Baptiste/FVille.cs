using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_FAU_Baptiste.Models
{
    public partial class FVille : Form
    {
        public FVille()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FVille_Load(object sender, EventArgs e)
        {
            bsVille.DataSource = ModelProjet.listeVille();
            dgvVille.DataSource = bsVille;

            dgvVille.Columns[0].Visible = false;
            dgvVille.Columns[2].HeaderText = "N° Département";
        }
    }
}
