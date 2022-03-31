using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBFrais.Model.Business
{
    public class LigneFraisForfait
    {
        private Visiteur idVisiteur;
        private DateTime mois;
        private string idFraisForfait;
        private decimal quantite;

        public LigneFraisForfait (string unIdVisiteur, DateTime unMois, string unIdFraisForfait, decimal uneQuantite)
        {
            this.mois = unMois;
            this.idFraisForfait = unIdFraisForfait;
            this.quantite = uneQuantite;
        }

        public Visiteur IdVisiteur
        {
            get
            {
                return idVisiteur;
            }
            set
            {
                idVisiteur = value;
            }
        }

        public DateTime Mois
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

        public string IdFraisForfait
        {
            get
            {
                return idFraisForfait;
            }
            set
            {
                idFraisForfait = value;
            }
        }

        public decimal Quantite
        {
            get
            {
                return quantite;
            }
            set
            {
                quantite = value;
            }
        }
        
    }
}
