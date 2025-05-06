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
    public partial class FGestionUtilisateurs : Form
    {
        public FGestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void FGestionUtilisateurs_Load(object sender, EventArgs e)
        {
            bsUtilisateurs.DataSource = ModelProjet.listeUtilisateur();
            dgvUtilisateurs.DataSource = bsUtilisateurs;

            dgvUtilisateurs.AutoGenerateColumns = true;
            dgvUtilisateurs.Columns[0].HeaderText = "Utilisateur";
            dgvUtilisateurs.Columns[1].Visible = false;
            dgvUtilisateurs.Columns[2].Visible = false;
            dgvUtilisateurs.Columns[3].HeaderText = "Actif";
            dgvUtilisateurs.Columns[4].Visible = false;
        }

        private void dgvUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnReactivation_Click(object sender, EventArgs e)
        {
            if (bsUtilisateurs.Current is Utilisateur uChoisi)
            {
                ModelProjet.ReactiverUtilisateur(uChoisi);
                dgvUtilisateurs.Refresh();
            }
        }

        private void btnDesactivation_Click(object sender, EventArgs e)
        {
            if (bsUtilisateurs.Current is Utilisateur uChoisi)
            {
                ModelProjet.DesactiverUtilisateur(uChoisi);
                dgvUtilisateurs.Refresh();
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (ModelProjet.UtilisateurConnecte.Droits != 3)
            {
                MessageBox.Show("Vous n'avez pas les droits pour créer un utilisateur.");
                return;
            }
            else
            {
                FAjoutUtilisateur fAjout = new FAjoutUtilisateur();
                fAjout.ShowDialog();
            }
        }
    }
}
