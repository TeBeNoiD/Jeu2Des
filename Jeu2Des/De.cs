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
    /// Définit un objet de type Dé utilisé par une partie
    /// </summary>
    public class De
    {
        #region Attributes and properties
        /// <summary>
        /// Valeur du Dé
        /// </summary>
        private int _Valeur;

        public int Valeur
        {
            get { return _Valeur; }
            protected set { _Valeur = value; }
        }

        private static Random _Random; 
        #endregion

        #region Constructors
        /// <summary>
        /// Constructeur par défaut => Valeur est affecté à 0;
        /// </summary>
        public De()
        {
            this.Valeur = 0;
            _Random = new Random();
        }
        #endregion

        #region Method
        /// <summary>
        /// Méthode pour lancer un dé
        /// affecte un entier compris entre 1 et 6 à la propriété Valeur
        /// </summary>
        public void Lancer()
        {
            this.Valeur = _Random.Next(1, 7);
        }
        
        #endregion
    }
}
