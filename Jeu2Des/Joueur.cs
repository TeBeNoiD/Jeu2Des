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
    /// Définit un joueur de la partie
    /// </summary>
    public class Joueur
    {
        #region Attributes and properties
        /// <summary>
        /// Nom du joueur
        /// </summary>
        public string Nom { get; set; }
        
        /// <summary>
        /// Score du joueur sur la partie en cours
        /// </summary>
        private int _Score;

        public int Score
        {
            get { return _Score; }
            protected set { _Score = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructeur complet 
        /// </summary>
        /// <param name="nom">Nom du joueur</param>
        public Joueur(string nom)
        {
            this.Nom = nom;
            this.Score = 0;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Joueur(): this("") { }
        #endregion

        #region Method
        public void Jouer()
        {
            De D1 = new De();
            D1.Lancer();

            De D2 = new De();
            D2.Lancer();

            //Si somme des valeurs des 2 dés est égale à 7
            //Alors on ajoute 10 au score du joueur
            if ((D1.Valeur + D2.Valeur) == 7)
            {
                this.Score += 10;
            }
        }
        #endregion
    }
}
