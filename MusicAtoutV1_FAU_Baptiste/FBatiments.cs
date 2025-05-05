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
    public partial class FBatiments : Form
    {
        public FBatiments()
        {
            InitializeComponent();
        }

        public void FBatiments_Load(object sender, EventArgs e)
        {
            bsBatiments.DataSource = ModelProjet.listeBatiment();
            dgvBatiments.DataSource = bsBatiments;
        }

        private void bsBatiments_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvBatiments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
