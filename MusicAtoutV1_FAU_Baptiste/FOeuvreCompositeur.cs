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
    public partial class FOeuvreCompositeur : Form
    {
        public FOeuvreCompositeur()
        {
            InitializeComponent();
        }

        private void FOeuvreCompositeur_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "idStyle";
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DataSource = bsStyle;
        }

        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {
            Style leStyleChoisi = (Style)bsStyle.Current;
            bsCompositeur.DataSource = leStyleChoisi.Compositeurs.ToList();

            dgvCompositeurStyle.DataSource = bsCompositeur;
            dgvCompositeurStyle.Columns[0].Visible = false;
            dgvCompositeurStyle.Columns[1].Visible = false;
            dgvCompositeurStyle.Columns[2].Visible = false;
            dgvCompositeurStyle.Columns[3].HeaderText = "Nom";
            dgvCompositeurStyle.Columns[4].HeaderText = "Prénom";
            dgvCompositeurStyle.Columns[5].Visible = false;
            dgvCompositeurStyle.Columns[6].Visible = false;
            dgvCompositeurStyle.Columns[7].Visible = false;
            dgvCompositeurStyle.Columns[8].Visible = false;
            dgvCompositeurStyle.Columns[9].Visible = false;
            dgvCompositeurStyle.Columns[10].Visible = false;
            dgvCompositeurStyle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            txtDebut.Text = leStyleChoisi.DateDebut.ToString();
            txtFin.Text = leStyleChoisi.DateFin.ToString();
        }

        private void bsCompositeur_CurrentChanged(object sender, EventArgs e)
        {
            Compositeur leCompositeurChoisi = (Compositeur)bsCompositeur.Current;

            txtCompositeur.Text = leCompositeurChoisi.PrenomCompositeur + leCompositeurChoisi.NomCompositeur;
            txtNationalite.Text = leCompositeurChoisi.IdNationNavigation.LibNation;
            txtStyle.Text = leCompositeurChoisi.IdNationNavigation.LibNation;
            txtNais.Text = leCompositeurChoisi.AnNais.ToString();
            txtMort.Text = leCompositeurChoisi.AnMort.ToString();
            txtRemarque.Text = leCompositeurChoisi.Remarque;

            if(leCompositeurChoisi.Oeuvres.ToList().Count() > 0 )
            {
                bsOeuvre.DataSource = leCompositeurChoisi.Oeuvres.ToList();
                dgvOeuvresCompositeur.DataSource = bsOeuvre;

                lbOeuvre.Visible = true;
                dgvOeuvresCompositeur.Visible = true;
                dgvOeuvresCompositeur.Columns[0].Visible = false;
                dgvOeuvresCompositeur.Columns[1].Visible = false;
                dgvOeuvresCompositeur.Columns[2].Visible = false;
                dgvOeuvresCompositeur.Columns[3].HeaderText = "Oeuvre";
                dgvOeuvresCompositeur.Columns[4].HeaderText = "Composition";
                dgvOeuvresCompositeur.Columns[5].Visible = false;
                dgvOeuvresCompositeur.Columns[6].Visible = false;
                dgvOeuvresCompositeur.Columns[7].Visible = false;
                dgvOeuvresCompositeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                lbOeuvre.Visible = false;
                dgvOeuvresCompositeur.Visible = false;
            }
        }
    }
}
