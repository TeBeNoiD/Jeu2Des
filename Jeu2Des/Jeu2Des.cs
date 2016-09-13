using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Jeu de dés avec 1 joueur et 2 dés
/// </summary>
namespace Jeu2Des
{
    /// <summary>
    /// Représente la partie du jeu à 2 dé
    /// </summary>
    public class Jeu2Des
    {
        #region Attributes and properties
        /// <summary>
        /// Collection de dé utilisée pendant la partie
        /// </summary>
        public List<De> Des { get; set; }

        /// <summary>
        /// Classement de la partie
        /// </summary>
        public Classement Classement { get; set; }

        /// <summary>
        /// Joueur de la partie
        /// </summary>
        public Joueur Joueur { get; set; }
        #endregion

        /// <summary>
        /// Constructeur complet 
        /// </summary>
        /// <param name="joueur">Joueur de la partie</param>
        /// <param name="classement">Classement des parties précédentes</param>
        #region Constructors
        public Jeu2Des(Joueur joueur, Classement classement)
        {
            this.Joueur = joueur;
            this.Classement = classement;

            //Ajout de 2 dés
            this.Des = new List<De>();
            Des.Add(new De());
            Des.Add(new De());
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Jeu2Des() : this(new Joueur(), new Classement()) { }
        #endregion

        #region Method
        /// <summary>
        /// Méthode pour joueur la partie 
        /// </summary>
        public void JouerPartie()
        {
            int NbTour = 10;
            for (int i = 0; i < NbTour; i++)
            {
                Console.WriteLine("Tour {0}, {1} a lancé les deux dés:", i+1, this.Joueur.Nom);
                this.Joueur.Jouer();

                //Au dernier tour on ajoute le score du joueur au classement
                if (i == NbTour - 1)
                {
                    this.Classement.AjouterEntree(new Entree(this.Joueur.Nom, this.Joueur.Score));
                    Console.WriteLine("Le score du joueur {0} est de {1}, BRAVO !!!", this.Joueur.Nom, this.Joueur.Score);
                }
            }
        }

        /// <summary>
        /// Récupérer le classement
        /// </summary>
        /// <returns>Collection définissant chaque entrée du classement</returns>
        public List<Entree> VoirClassement()
        {
            return this.Classement.Entrees;
        }
        #endregion
    }
}
