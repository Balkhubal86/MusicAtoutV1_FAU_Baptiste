using Microsoft.EntityFrameworkCore;
using MusicAtoutV1_FAU_Baptiste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MusicAtoutV1_FAU_Baptiste
{
    public class ModelProjetTests
    {
        private Sio2musicAtoutFauContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<Sio2musicAtoutFauContext>()
                .UseInMemoryDatabase(databaseName: "TestDb_" + Guid.NewGuid()) // unique db per test
                .Options;

            return new Sio2musicAtoutFauContext(options);
        }

        public ModelProjetTests()
        {
            // Création d'un contexte en mémoire à chaque test
            var context = GetInMemoryContext();
            ModelProjet.MonModel = context;
        }

        [Fact] // test de la méthode listeVille
        public void ListeVille_ReturnsEmptyList_WhenNoData()
        {
            var result = ModelProjet.listeVille();
            Assert.Empty(result);
        }

        [Fact] // test de la méthode listeSalle
        public void AjoutCompositeur_ShouldAddNewCompositeur()
        {
            var result = ModelProjet.AjoutCompositeur("Mozart", "Wolfgang", "Génie musical", 1756, 1791, 1, 1);
            Assert.True(result);

            var list = ModelProjet.listeCompositeur();
            Assert.Single(list);
            Assert.Equal("Mozart", list.First().NomCompositeur);
        }

        [Fact] // test de la méthode ModifCompositeur
        public void ModifCompositeur_ShouldUpdateCompositeur()
        {
            ModelProjet.AjoutCompositeur("Bach", "Jean", "", 1685, 1750, 1, 1);
            var compo = ModelProjet.listeCompositeur().First();
            ModelProjet.CompositeurChoisi = compo;

            var result = ModelProjet.ModifCompositeur("Bach", "Jean-Sébastien", "Très connu", 1685, 1750, 1, 1);
            Assert.True(result);

            var updated = ModelProjet.listeCompositeur().First();
            Assert.Equal("Jean-Sébastien", updated.PrenomCompositeur);
        }

        [Fact] // test de la méthode SuppCompositeur
        public void SuppCompositeur_ShouldRemoveCompositeur()
        {
            ModelProjet.AjoutCompositeur("Beethoven", "Ludwig", "", 1770, 1827, 1, 1);
            ModelProjet.CompositeurChoisi = ModelProjet.listeCompositeur().First();

            var result = ModelProjet.SuppCompositeur();
            Assert.True(result);

            Assert.Empty(ModelProjet.listeCompositeur());
        }

        [Fact] // test de la méthode MotDePasseValide
        public void MotDePasseValide_ShouldReturnTrue_WhenStrong()
        {
            var result1 = ModelProjet.MotDePasseValide("Secure123!");
            Assert.False(result1);

            var result2 = ModelProjet.MotDePasseValide("StrongPass1@");
            Assert.True(result2);
        }

        [Fact] // test de la méthode AjouterUtilisateur
        public void AjouterUtilisateur_ShouldAddUser_WhenValid()
        {
            ModelProjet.UtilisateurConnecte = new Utilisateur { Droits = 3 };
            var result = ModelProjet.AjouterUtilisateur("admin", 2, "Admin123!");

            Assert.True(result);

            var user = ModelProjet.listeUtilisateur().FirstOrDefault();
            Assert.NotNull(user);
            Assert.Equal("admin", user.IdUtilisateur);
        }

        [Fact] // test de la méthode AjouterUtilisateur
        public void AjouterUtilisateur_ShouldFail_WhenPasswordInvalid()
        {
            ModelProjet.UtilisateurConnecte = new Utilisateur { Droits = 3 };
            var result = ModelProjet.AjouterUtilisateur("baduser", 2, "123");

            Assert.False(result);
            Assert.Empty(ModelProjet.listeUtilisateur());
        }

        [Fact] // test de la méthode AjouterUtilisateur
        public void AjouterUtilisateur_ShouldFail_WhenUserAlreadyExists()
        {
            ModelProjet.UtilisateurConnecte = new Utilisateur { Droits = 3 };
            ModelProjet.AjouterUtilisateur("user1", 2, "Password1!");
            var result = ModelProjet.AjouterUtilisateur("user1", 2, "Password1!");

            Assert.False(result);
            Assert.Single(ModelProjet.listeUtilisateur());
        }

        [Fact] // test de la méthode AjouterUtilisateur
        public void ValidConnexion_ShouldSucceed_WhenCorrectPassword()
        {
            var db = ModelProjet.MonModel;
            var hashMdp = "0x" + ModelProjet.GetMd5Hash("Password123!");
            var user = new Utilisateur
            {
                IdUtilisateur = "testuser",
                Droits = 2,
                Passwd = hashMdp,
                Actif = true,
                Nbessais = 0
            };
            db.Utilisateurs.Add(user);
            db.SaveChanges();

            var result = ModelProjet.validConnexion("testuser", "Password123!");
            Assert.True(result);
            Assert.Equal(0, user.Nbessais);
        }

        [Fact]
        public void ValidConnexion_ShouldFail_WhenWrongPassword()
        {
            var db = ModelProjet.MonModel;
            var hashMdp = "0x" + ModelProjet.GetMd5Hash("Password123!");
            var user = new Utilisateur
            {
                IdUtilisateur = "userfail",
                Droits = 2,
                Passwd = hashMdp,
                Actif = true,
                Nbessais = 0
            };
            db.Utilisateurs.Add(user);
            db.SaveChanges();

            var result = ModelProjet.validConnexion("userfail", "WrongPassword!");
            Assert.False(result);
            Assert.Equal(1, user.Nbessais);
        }

        [Fact]
        public void ChangeMdp_ShouldSucceed_WhenCorrectData()
        {
            var user = new Utilisateur
            {
                IdUtilisateur = "changepwd",
                Passwd = "0x" + ModelProjet.GetMd5Hash("oldpass"),
                Droits = 2,
                Actif = true
            };
            ModelProjet.MonModel.Utilisateurs.Add(user);
            ModelProjet.MonModel.SaveChanges();

            ModelProjet.UtilisateurConnecte = user;

            var result = ModelProjet.ChangeMdp("oldpass", "Newpass123!", "Newpass123!");
            Assert.True(result);

            var updated = ModelProjet.MonModel.Utilisateurs.First(u => u.IdUtilisateur == "changepwd");
            Assert.Equal("0x" + ModelProjet.GetMd5Hash("Newpass123!"), updated.Passwd);
        }

        [Fact]
        public void ChangeMdp_ShouldFail_WhenConfirmationDoesNotMatch()
        {
            var user = new Utilisateur
            {
                IdUtilisateur = "failconfirm",
                Passwd = "0x" + ModelProjet.GetMd5Hash("mypassword"),
                Droits = 2,
                Actif = true
            };
            ModelProjet.MonModel.Utilisateurs.Add(user);
            ModelProjet.MonModel.SaveChanges();

            ModelProjet.UtilisateurConnecte = user;

            var result = ModelProjet.ChangeMdp("mypassword", "newone", "different");
            Assert.False(result);
            Assert.Contains("ne correspondent pas", MessageBoxMock.LastMessage);
        }

    }
}
