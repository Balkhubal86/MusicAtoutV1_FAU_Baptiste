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
    public partial class FCompositeurStyle : Form
    {
        public FCompositeurStyle()
        {
            InitializeComponent();
        }

        private void FCompositeurStyle_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "idStyle";
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DataSource = bsStyle;
        }

        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {
            Style leStyleChoisi = (Style)bsStyle.Current;
            txtDebut.Text = leStyleChoisi.DateDebut.ToString();
            txtFin.Text = leStyleChoisi.DateFin.ToString();
            bsCompositeur.DataSource = leStyleChoisi.Compositeurs.Select(x => new { x.NomCompositeur, x.PrenomCompositeur, x.IdStyleNavigation.LibStyle, x.AnNais, x.AnMort });
            dgvCompositeur.DataSource = bsCompositeur;
        }
    }
}
