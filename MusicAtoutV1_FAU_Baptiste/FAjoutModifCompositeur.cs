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
    public partial class FAjoutModifCompositeur : Form
    {
        public FAjoutModifCompositeur()
        {
            InitializeComponent();
        }

        private void FAjoutModifCompositeur_Load(object sender, EventArgs e)
        {
            if (ModelProjet.ActionGestionCompositeur == 1) // Ajout
            {
                cboStyle.ValueMember = "IdStyle";
                cboStyle.DisplayMember = "LibStyle";
                bsStyle.DataSource = ModelProjet.listeStyle();
                cboStyle.DataSource = bsStyle;

                cboNation.ValueMember = "idNation";
                cboNation.DisplayMember = "libNation";
                bsNation.DataSource = ModelProjet.listeNationalite();
                cboNation.DataSource = bsNation;
            }
            else if (ModelProjet.ActionGestionCompositeur == 2) // Modif
            {
                tbNom.Text = ModelProjet.CompositeurChoisi.NomCompositeur;
                tbPrenom.Text = ModelProjet.CompositeurChoisi.PrenomCompositeur;
                tbNais.Text = ModelProjet.CompositeurChoisi.AnNais.ToString();
                tbMort.Text = ModelProjet.CompositeurChoisi.AnMort.ToString();
                tbRemarque.Text = ModelProjet.CompositeurChoisi.Remarque;

                cboStyle.ValueMember = "IdStyle";
                cboStyle.DisplayMember = "LibStyle";
                bsStyle.DataSource = ModelProjet.listeStyle();
                cboStyle.DataSource = bsStyle;
                cboStyle.Text = ModelProjet.CompositeurChoisi.IdStyleNavigation.LibStyle;

                cboNation.ValueMember = "idNation";
                cboNation.DisplayMember = "libNation";
                bsNation.DataSource = ModelProjet.listeNationalite();
                cboNation.DataSource = bsNation;
                cboNation.Text = ModelProjet.CompositeurChoisi.IdNationNavigation.LibNation;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ModelProjet.ActionGestionCompositeur == 1) // Ajout
            {
                if (tests())
                {
                    ModelProjet.AjoutCompositeur(tbNom.Text, tbPrenom.Text, tbRemarque.Text, int.Parse(tbNais.Text), int.Parse(tbMort.Text), ((Nationalite)bsNation.Current).IdNation, ((Style)bsStyle.Current).IdStyle);
                    MessageBox.Show("Ajout Réussi !");
                    Close();
                }
            }
            else if (ModelProjet.ActionGestionCompositeur == 2) // Modif
            {
                if (tests())
                {
                    ModelProjet.ModifCompositeur(tbNom.Text, tbPrenom.Text, tbRemarque.Text, int.Parse(tbNais.Text), int.Parse(tbMort.Text), ((Nationalite)bsNation.Current).IdNation, ((Style)bsStyle.Current).IdStyle);
                    MessageBox.Show("Modification Réussi !");
                    Close();
                }
            }
        }

        private bool tests()
        {
            bool vretour = true;
            error1.Clear();
            if (String.IsNullOrEmpty(tbNom.Text))
            {
                error1.SetError(tbNom, "Le nom du compositeur doit être renseigné.");
                vretour = false;
            }
            if (String.IsNullOrEmpty(tbPrenom.Text))
            {
                error1.SetError(tbPrenom, "Le prénom du compositeur doit être renseigné.");
                vretour = false;
            }
            if (String.IsNullOrEmpty(tbRemarque.Text))
            {
                error1.SetError(tbRemarque, "La remarque du compositeur doit être renseigné");
                vretour = false;
            }
            if (!int.TryParse(tbNais.Text, out int resultNais) || resultNais < 500)
            {
                error1.SetError(tbNais, "Renseigner un nombre valide supérieur à 500");
                vretour = false;
            }
            if (!int.TryParse(tbMort.Text, out int resultMort) || resultMort < (resultNais + 15) && resultMort > (resultNais + 125))
            {
                error1.SetError(tbMort, "Renseigner un nombre valide");
                vretour = false;
            }
            return vretour;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
