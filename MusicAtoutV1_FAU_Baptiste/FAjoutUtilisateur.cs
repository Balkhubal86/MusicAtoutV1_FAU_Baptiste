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
    public partial class FAjoutUtilisateur : Form
    {
        public FAjoutUtilisateur()
        {
            InitializeComponent();
        }

        private void lbMdp_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            string id = tbIdentifiant.Text;
            string mdp = tbMdp.Text;
            string confirmeMdp = tbConfMdp.Text;
            int droit = Decimal.ToInt32(nudDroit.Value);

            if (mdp == confirmeMdp)
            {
                ModelProjet.AjouterUtilisateur(id, droit, mdp);
            }
        }
    }
}
