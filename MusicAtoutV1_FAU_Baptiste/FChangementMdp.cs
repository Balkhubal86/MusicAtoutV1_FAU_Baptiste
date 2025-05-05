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

            if (nouveau != confirmation)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }

            if (ModelProjet.UtilisateurConnecte.Passwd != GetMd5Hash(ancien)) 
            {
                MessageBox.Show("Ancien mot de passe incorrect.");
                return;
            }

            if (!MotDePasseValide(nouveau))
            {
                MessageBox.Show("Le mot de passe ne respecte pas les règles.");
                return;
            }

            ModelProjet.UtilisateurConnecte.Passwd = GetMd5Hash(nouveau); 

            // Sauvegarder dans la base de données via Entity Framework
            using (var db = new Sio2musicAtoutFauContext())
            {
                db.Utilisateurs.Update(ModelProjet.UtilisateurConnecte);
                db.SaveChanges();
            }

            MessageBox.Show("Mot de passe modifié avec succès !");
            this.Close();
        }

        private bool MotDePasseValide(string mdp)
        {
            string special = @"()[]{}@ !$,;:/";
            bool estValide = mdp.Length >= 8
                             && mdp.Any(char.IsDigit)
                             && mdp.Any(c => special.Contains(c));

            return estValide;
        }

        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
