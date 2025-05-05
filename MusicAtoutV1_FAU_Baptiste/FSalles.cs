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
    public partial class FSalles : Form
    {
        public FSalles()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        public void FSalles_Load(object sender, EventArgs e)
        {
            bsSalle.DataSource = ModelProjet.listeSalle();
            dgvSalle.DataSource = bsSalle;
        }
    }
}
