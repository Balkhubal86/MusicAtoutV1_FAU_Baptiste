using MusicAtoutV1_FAU_Baptiste.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_FAU_Baptiste
{
    public partial class FCompositeurNation : Form
    {
        public FCompositeurNation()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FCompositeurNation_Load(object sender, EventArgs e)
        {
            cboNation.ValueMember = "idNation";//permet de stocker l'identifiant
            cboNation.DisplayMember = "libNation";
            bsNation.DataSource = ModelProjet.listeNationalite();
            cboNation.DataSource = bsNation;
        }

        private void bsNation_CurrentChanged(object sender, EventArgs e)
        {
            Nationalite laNationaliteChoisie = (Nationalite)bsNation.Current;
            bsCompositeur.DataSource = laNationaliteChoisie.Compositeurs.Select(x => new { x.NomCompositeur, x.PrenomCompositeur, x.IdStyleNavigation.LibStyle, x.AnNais, x.AnMort, x.Remarque, x.IdCompositeur }).OrderBy(x => x.NomCompositeur).ToList(); ;
            dgvCompositeur.DataSource = bsCompositeur;
            dgvCompositeur.Columns[0].HeaderText = "NOM";
            dgvCompositeur.Columns[1].HeaderText = "PRENOM";
            dgvCompositeur.Columns[2].HeaderText = "STYLE";
            dgvCompositeur.Columns[3].HeaderText = "Né le";
            dgvCompositeur.Columns[4].HeaderText = "Mort le";
            dgvCompositeur.Columns[5].HeaderText = "Informations";
            dgvCompositeur.Columns[6].Visible = false;
            dgvCompositeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red)
            {
                cboNation.Enabled = false;
                button1.BackColor = Color.Green;
                dgvCompositeur.DataSource = ModelProjet.listeCompositeur();
            }
            else
            {
                cboNation.Enabled = true;
                button1.BackColor = Color.Red;
                dgvCompositeur.DataSource = bsCompositeur;
            }
        }

        private void btModif_Click_1(object sender, EventArgs e)
        {
            System.Type type = bsCompositeur.Current.GetType();
            int id = (int)type.GetProperty("IdCompositeur").GetValue(bsCompositeur.Current, null);
            ModelProjet.CompositeurChoisi = ModelProjet.compositeurAPartirDeLId(id);
            ModelProjet.ActionGestionCompositeur = 2;

            FAjoutModifCompositeur fAjoutModifCompositeur = new FAjoutModifCompositeur();
            fAjoutModifCompositeur.ShowDialog();
        }

        private void btAjout_Click(object sender, EventArgs e)
        {
            ModelProjet.ActionGestionCompositeur = 1;
            FAjoutModifCompositeur fAjoutModifCompositeur = new FAjoutModifCompositeur();
            fAjoutModifCompositeur.ShowDialog();
        }

        private void btSupp_Click(object sender, EventArgs e)
        {
            System.Type type = bsCompositeur.Current.GetType();
            int id = (int)type.GetProperty("IdCompositeur").GetValue(bsCompositeur.Current, null);
            ModelProjet.CompositeurChoisi = ModelProjet.compositeurAPartirDeLId(id);

            if (MessageBox.Show("Etes vous sur de vouloir supprimer le compositeur :" + ModelProjet.CompositeurChoisi.PrenomCompositeur.Trim() + " - " + ModelProjet.CompositeurChoisi.NomCompositeur.Trim(), "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ModelProjet.SuppCompositeur();
                MessageBox.Show("Compositeur : " + ModelProjet.CompositeurChoisi.PrenomCompositeur.Trim() + " - " + ModelProjet.CompositeurChoisi.NomCompositeur.Trim() + " a été supprimé !");
                Close();
            }
        }
    }
}
