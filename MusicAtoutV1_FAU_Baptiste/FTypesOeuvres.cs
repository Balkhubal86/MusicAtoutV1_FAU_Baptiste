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
    public partial class FTypesOeuvres : Form
    {
        public FTypesOeuvres()
        {
            InitializeComponent();
        }

        public void FTypesOeuvres_Load(object sender, EventArgs e)
        {
            bsTO.DataSource = ModelProjet.listeTypeoeuvre();
            dgvTO.DataSource = bsTO;
        }
    }
}
