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
    /// Objet regroupant les scores des parties précédentes
    /// </summary>
    public class Classement
    {
        /// <summary>
        /// Collection des entréés de l'objet Classement
        /// </summary>
        #region Attributes and properties
        private List<Entree> _Entrees;

        public List<Entree> Entrees
        {
            get { return _Entrees; }
            protected set { _Entrees = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructeur par défaut => initialise une instance de la propriété Entrees
        /// </summary>
        public Classement()
        {
            this.Entrees = new List<Entree>();
        }
        #endregion

        #region Method
        /// <summary>
        /// Ajouter une entrée au classement
        /// </summary>
        /// <param name="entree"></param>
        public void AjouterEntree(Entree entree)
        {
            this.Entrees.Add(entree);
        }

        /// <summary>
        /// Afficher le classement des N meilleurs entrées
        /// </summary>
        public void TopN()
        {
            //TODO Implémenter la méthode TopN de la classe Classement
        }
        #endregion
    }
}
