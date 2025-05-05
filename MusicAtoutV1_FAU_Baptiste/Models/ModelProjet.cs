using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MusicAtoutV1_FAU_Baptiste.Models
{
    public static class ModelProjet
    {
        private static Sio2musicAtoutFauContext monModel;
        private static int actionGestionCompositeur;
        private static Compositeur compositeurChoisi;
        private static Utilisateur utilisateurConnecte;
        private static bool connexionValide;
        private static bool newUser;


        public static Sio2musicAtoutFauContext MonModel { get => monModel; set => monModel = value; }
        public static int ActionGestionCompositeur { get => actionGestionCompositeur; set => actionGestionCompositeur = value; }
        public static Compositeur CompositeurChoisi { get => compositeurChoisi; set => compositeurChoisi = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }
        public static Utilisateur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }

        public static void init()
        {
            monModel = new Sio2musicAtoutFauContext();
        }
        public static List<Ville> listeVille()
        {
            return monModel.Villes.ToList();
        }

        public static List<Salle> listeSalle()
        {
            return monModel.Salles.ToList();
        }

        public static List<Batiment> listeBatiment()
        {
            return monModel.Batiments.ToList();
        }

        public static List<Typeoeuvre> listeTypeoeuvre()
        {
            return monModel.Typeoeuvres.ToList();
        }

        public static List<Nationalite> listeNationalite()
        {
            return monModel.Nationalites.ToList();
        }

        public static List<Compositeur> listeCompositeur()
        {
            return monModel.Compositeurs.ToList();
        }

        public static List<Style> listeStyle()
        {
            return monModel.Styles.ToList();
        }

        public static List<Oeuvre> listeOeuvre()
        {
            return monModel.Oeuvres.ToList();
        }

        public static Compositeur compositeurAPartirDeLId(int id)
        {
            Compositeur vretour = null;
            vretour = monModel.Compositeurs.Where(x => x.IdCompositeur == id).ToList()[0];
            return vretour;
        }

        public static bool ModifCompositeur(string nom, string prenom, string remarque, int? anNais, int? anMort, int idNation, int idStyle)
        {
            bool vretour = true;
            try
            {
                compositeurChoisi.NomCompositeur = nom;
                compositeurChoisi.PrenomCompositeur = prenom;
                compositeurChoisi.Remarque = remarque;
                compositeurChoisi.AnNais = anNais;
                compositeurChoisi.AnMort = anMort;
                compositeurChoisi.IdNation = idNation;
                compositeurChoisi.IdStyle = idStyle;
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool AjoutCompositeur(string nom, string prenom, string remarque, int? anNais, int? anMort, int idNation, int idStyle)
        {
            bool vretour = true;
            try
            {
                compositeurChoisi = new Compositeur();
                compositeurChoisi.NomCompositeur = nom;
                compositeurChoisi.PrenomCompositeur = prenom;
                compositeurChoisi.Remarque = remarque;
                compositeurChoisi.AnNais = anNais;
                compositeurChoisi.AnMort = anMort;
                compositeurChoisi.IdNation = idNation;
                compositeurChoisi.IdStyle = idStyle;
                monModel.Compositeurs.Add(compositeurChoisi);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
        public static bool SuppCompositeur()
        {
            bool vretour = true;
            try
            {
                monModel.Compositeurs.Remove(compositeurChoisi);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
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

        public static bool validConnexion(string id, string mp)
        {
            string message = "";
            // Ecrire le code qui renvoie le message à afficher et mets à jour les variables utilisateurConnecte et connexionValide,
            // la comparaison des mots de passes se fera via utilisateurConnecte.passwd.Substring(2).Equals(GetMd5Hash(mp))
            if(monModel.Utilisateurs.Where(x => x.IdUtilisateur == id).ToList().Count == 1)
            {
                utilisateurConnecte = monModel.Utilisateurs.Where(x => x.IdUtilisateur == id).ToList()[0];

                if (utilisateurConnecte.Nbessais == 4) 
                {
                    if (utilisateurConnecte.IdUtilisateur.Substring(2).Equals(GetMd5Hash(mp)))
                    {
                        connexionValide = true;
                        utilisateurConnecte.Nbessais = 0;
                        newUser = true;
                    }
                }

                if(utilisateurConnecte.Actif && utilisateurConnecte.Nbessais < 3)
                {
                    if (utilisateurConnecte.Passwd.Substring(2).Equals(GetMd5Hash(mp)))
                    {
                        connexionValide = true;
                        utilisateurConnecte.Nbessais = 0;
                    }
                    else
                    {
                        utilisateurConnecte.Nbessais++;
                        message += "Nom d'utilisateur ou mot de passe incorrect\n";
                        connexionValide = false;
                        if (utilisateurConnecte.Nbessais > 3)
                        {
                            message += "Nombre d'essai dépassé. Patientez avant une nouvelle tentative.\n";
                            utilisateurConnecte.Actif = false;
                        }
                    }
                }
                else
                {
                    connexionValide = false;
                    message += "Compte Désactivé...";
                    if(utilisateurConnecte.Nbessais == 3 && utilisateurConnecte.Actif)
                    {
                        utilisateurConnecte.Actif = false;
                    }
                }
            }
            else
            {
                message += "Nom d'utilisateur ou mot de passe incorrect\n";
            }

            if(message != "")
            {
                MessageBox.Show(message);
            }

            monModel.SaveChanges();
            return connexionValide;
        }

    }
}
