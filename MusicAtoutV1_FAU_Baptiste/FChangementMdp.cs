using MusicAtoutV1_FAU_Baptiste.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_FAU_Baptiste
{
    public partial class FChangementMdp : Form
    {
        public FChangementMdp()
        {
            InitializeComponent();
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            string ancien = tbAncienMdp.Text;
            string nouveau = tbNouveauMdp.Text;
            string confirmation = tbConfirmMdp.Text;

            ModelProjet.ChangeMdp(ancien, nouveau, confirmation);
        }


    }
}
