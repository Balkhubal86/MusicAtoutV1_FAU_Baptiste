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

        public static List<Utilisateur> listeUtilisateur()
        {
            return monModel.Utilisateurs.ToList();
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
        // ---------------------
        // Section Mot de Passe 
        // ---------------------
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
                    if (utilisateurConnecte.Passwd.Substring(2).Equals(GetMd5Hash(mp)))
                    {
                        connexionValide = true;
                        utilisateurConnecte.Nbessais = 0;

                        FChangementMdp fChangementMdp = new FChangementMdp();
                        fChangementMdp.ShowDialog();
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

        public static bool ChangeMdp(string ancien, string nouveau, string confirmation)
        {
            string message = "";
            string hashAncien = GetMd5Hash(ancien);
            string hashNouveau = GetMd5Hash(nouveau);

            if (nouveau != confirmation) // Vérifie si le mot de passe de confirmation est identique au nouveau mot de passe
            {
                message = "Les mots de passe ne correspondent pas.";
            }
            else if (!utilisateurConnecte.Passwd.Substring(2).Equals("0x"+ hashAncien)) // Vérifie si l'ancien mot de passe est correct
            {
                message = "Ancien mot de passe incorrect.";
            }
            else if (!MotDePasseValide(nouveau)) // Vérifie si le nouveau mot de passe respecte les règles
            {
                message = "Le mot de passe ne respecte pas les règles.";
            }
            else
            {
                utilisateurConnecte.Passwd = hashNouveau;

                using (var db = new Sio2musicAtoutFauContext())
                {
                    var user = db.Utilisateurs.FirstOrDefault(u => u.IdUtilisateur == utilisateurConnecte.IdUtilisateur);
                    if (user != null)
                    {
                        user.Passwd = "0x" + hashNouveau;
                        db.SaveChanges();
                    }
                }

                return true; // Succès
            }

            MessageBox.Show(message);
            return false;
        }

        public static bool MotDePasseValide(string mdp)
        {
            string special = @"()[]{}@ !$,;:/";
            bool estValide = mdp.Length >= 8
                             && mdp.Any(char.IsDigit)
                             && mdp.Any(c => special.Contains(c));

            return estValide;
        }

        // ---------------------
        // Gestion Utilisateurs
        // ---------------------
        public static void ReactiverUtilisateur(Utilisateur uChoisi)
        {
            if (UtilisateurConnecte.Droits >= 2 && UtilisateurConnecte.Droits >= uChoisi.Droits)
            {
                uChoisi.Actif = true;
                uChoisi.Nbessais = 4;
                uChoisi.Passwd = GetMd5Hash(uChoisi.IdUtilisateur); // Le mot de passe temporaire = identifiant
                MessageBox.Show($"Compte {uChoisi.IdUtilisateur} réactivé !");
            }
            else
            {
                MessageBox.Show("Vous n'avez pas les droits pour réactiver ce compte.");
            }
        }

        public static void DesactiverUtilisateur(Utilisateur uChoisi)
        {
            if (UtilisateurConnecte.Droits == 3)
            {
                uChoisi.Actif = false;
                uChoisi.Nbessais = 4;
                MessageBox.Show($"Compte {uChoisi.IdUtilisateur} désactivé !");
            }
            else
            {
                MessageBox.Show("Droits insuffisants pour désactiver un utilisateur.");
            }
        }

        public static bool AjouterUtilisateur(string id, int droits, string mdp)
        {
            bool vretour = true;
            try
            {
                // Vérifie que l'identifiant est unique
                if (monModel.Utilisateurs.Any(u => u.IdUtilisateur == id))
                {
                    MessageBox.Show("Cet identifiant existe déjà.");
                    vretour = false;
                }

                // Varifie que le mdp est valide
                if (!MotDePasseValide(mdp))
                {
                    MessageBox.Show("Mot de passe invalide.");
                    vretour = false;
                }

                //
                if (UtilisateurConnecte.Droits == 3 && vretour)
                {
                    Utilisateur newUser = new Utilisateur
                    {
                        IdUtilisateur = id,
                        Droits = droits,
                        Actif = true,
                        Nbessais = 4,
                        Passwd = "0x" + GetMd5Hash(mdp)
                    };

                    monModel.Utilisateurs.Add(newUser);
                    monModel.SaveChanges();
                    MessageBox.Show($"Utilisateur {id} ajouté avec succès.");
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas les droits pour créer un utilisateur.");
                    vretour = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'utilisateur : " + ex.Message);
                vretour = false;
            }

            return vretour;
        }

    }
}
