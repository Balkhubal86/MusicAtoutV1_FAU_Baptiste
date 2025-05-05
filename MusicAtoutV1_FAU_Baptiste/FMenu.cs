using MusicAtoutV1_FAU_Baptiste.Models;

namespace MusicAtoutV1_FAU_Baptiste
{
    public partial class Fmenu : Form
    {
        public Fmenu()
        {
            InitializeComponent();
        }

        private void villesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVille maForm = new FVille();
            maForm.Show();
        }

        private void sallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSalles fSalles = new FSalles();
            fSalles.Show();
        }

        private void batimentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBatiments fBatiments = new FBatiments();
            fBatiments.Show();
        }

        private void typesDoeuvreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTypesOeuvres fTypesOeuvres = new FTypesOeuvres();
            fTypesOeuvres.Show();
        }

        private void parNationalitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompositeurNation fCompositeurNation = new FCompositeurNation();
            fCompositeurNation.Show();
        }

        private void parStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompositeurStyle fCompositeurStyle = new FCompositeurStyle();
            fCompositeurStyle.Show();
        }

        private void oeuvresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FOeuvreCompositeur fOeuvreCompositeur = new FOeuvreCompositeur();
            fOeuvreCompositeur.Show();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAjoutModifCompositeur fAjoutModifCompositeur = new FAjoutModifCompositeur();
            fAjoutModifCompositeur.ShowDialog();
        }

        private void Fmenu_Load(object sender, EventArgs e)
        {
            if (ModelProjet.UtilisateurConnecte.Droits == 3)
            {
                gestionToolStripMenuItem.Visible = true;
            }
            else
            {
                gestionToolStripMenuItem.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread t = new Thread(() =>
            {
                Application.Run(new FConnexion());
            });

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void changementMdpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChangementMdp fChangementMdp = new FChangementMdp();
            fChangementMdp.ShowDialog();
        }

        private void gestionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FGestionUtilisateurs fGestionUtilisateurs = new FGestionUtilisateurs();
            fGestionUtilisateurs.ShowDialog();
        }
    }
}
