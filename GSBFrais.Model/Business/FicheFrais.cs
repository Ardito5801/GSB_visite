using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBFrais.Model.Business
{
    public class FicheFrais
    {
        private Visiteur unVisiteur;
        private string mois;
        private Etat unEtat;
        private decimal montantValide;
        private int nbJustificatifs;
        private DateTime dateModif;

        public FicheFrais (Visiteur leVisiteur, string unMois, Etat unEtat, decimal unMontantValide, int unNbJustificatifs,DateTime uneDateModif)
        {
            this.unVisiteur = leVisiteur;
            this.mois = unMois;
            this.unEtat = unEtat;
            this.montantValide = unMontantValide;
            this.nbJustificatifs = unNbJustificatifs;
            this.dateModif = uneDateModif;
        }

        public Visiteur UnVisiteur
        {
            get
            {
                return unVisiteur;
            }

            set
            {
                unVisiteur = value;
            }
        }

        public string Mois
        {
            get
            {
                return mois;
            }

            set
            {
                mois = value;
            }
        }

        internal Etat UnEtat
        {
            get
            {
                return unEtat;
            }

            set
            {
                unEtat = value;
            }
        }

        public decimal MontantValide
        {
            get
            {
                return montantValide;
            }

            set
            {
                montantValide = value;
            }
        }

        public int NbJustificatifs
        {
            get
            {
                return nbJustificatifs;
            }

            set
            {
                nbJustificatifs = value;
            }
        }

        public DateTime DateModif
        {
            get
            {
                return dateModif;
            }

            set
            {
                dateModif = value;
            }
        }
        public override string ToString()
        {
            return unVisiteur.Id + "--" + mois + "--" + unVisiteur.Nom;
        }
    }
}
