using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBFrais.Model.Business
{
    public class LigneFraisHorsForfait
    {
        private int id;
        private Visiteur idVisiteur;
        private DateTime mois;
        private string libelle;
        private DateTime date;
        private decimal montant;

        public LigneFraisHorsForfait(int unId, string unIdVisiteur, DateTime unMois, string unLibelle, DateTime uneDate, decimal unMontant)
        {
            this.id = unId;
            this.mois = unMois;
            this.libelle = unLibelle;
            this.date = uneDate;
            this.montant = unMontant;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
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

        public string Libelle
        {
            get
            {
                return libelle;
            }
            set
            {
                libelle = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public decimal Montant
        {
            get
            {
                return montant;
            }
            set
            {
                montant = value;
            }
        }

    }
}
