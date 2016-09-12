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
    /// Définit un objet représentant une ligne du classement
    /// </summary>
    public class Entree
    {
        #region Attributes and properties
        /// <summary>
        /// Propriété définissant le nom du joueur
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Propriété définissant le score du joueur
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
        /// Constructeur complet => instancie un objet Entree à partir du nom et du score d'un joueur
        /// </summary>
        public Entree(string nom, int score)
        {
            this.Nom = nom;
            this.Score = score;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Entree() : this("ABC", 0) { }
        #endregion

        #region Method

        #endregion
    }
}
