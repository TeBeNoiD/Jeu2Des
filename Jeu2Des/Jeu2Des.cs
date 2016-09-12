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
            //TODO Implémenter la méthode pour joueur la partie
        }

        /// <summary>
        /// Affichage du classement
        /// </summary>
        public void VoirClassement()
        {
            //TODO Implémenter la méthode pour voir le classement
        }
        #endregion
    }
}
