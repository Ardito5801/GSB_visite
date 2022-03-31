using GSBFrais.Model.Business;
using GSBFrais.Model.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBFrais.Model.Data
{
    public class DaoLigneFraisForfait
    {
        private Dbal _dbal;
        private DaoVisiteur _daoVisiteur;
        private DaoLigneFraisForfait _daoFraisForfait;

        public DaoLigneFraisForfait (Dbal unDbal, DaoVisiteur uneDaoVisiteur, DaoLigneFraisForfait uneDaoLigneFraisForfait)
        {
            this._dbal = unDbal;
            this._daoVisiteur = uneDaoVisiteur;
            this._daoFraisForfait = uneDaoLigneFraisForfait;
        }

        public DaoLigneFraisForfait(Dbal unDbal)
        {
            this._dbal = unDbal;
        }

        public void Insert(LigneFraisForfait uneLigneFraisForfait)
        {
            string query = " ligneFraisForfait (idVisiteur, mois, idFraitForfait, quantite) VALUES ('" + uneLigneFraisForfait.IdVisiteur + "','" + uneLigneFraisForfait.Mois + "','" + uneLigneFraisForfait.IdFraisForfait + "','" + uneLigneFraisForfait.Quantite + "')";
            this._dbal.Insert(query);
        }

        public void Update(LigneFraisForfait uneLigneFraisForfait)
        {
            string query = " ligneFraisForfait (idVisiteur, mois, idFraitForfait, quantite) SET '" + uneLigneFraisForfait.IdVisiteur + "','" + uneLigneFraisForfait.Mois + "','" + uneLigneFraisForfait.IdFraisForfait + "','" + uneLigneFraisForfait.Quantite + "'";
            this._dbal.Update(query);
        }

        public void Delete(LigneFraisForfait uneLigneFraisForfait)
        {
            string query = " visiteur WHERE idVisiteur ='" + uneLigneFraisForfait.IdVisiteur + "'AND idFraitForfait ='" + uneLigneFraisForfait.IdFraisForfait + "'";
            this._dbal.Delete(query);
        }

        public List<LigneFraisForfait> SelectAll()
        {
            List<LigneFraisForfait> listLigneFraisForfait = new List<LigneFraisForfait>();
            DataTable myTable = this._dbal.SelectAll("ligneFraisForfait");

            foreach (DataRow r in myTable.Rows)
            {
                listLigneFraisForfait.Add(new LigneFraisForfait((string)r["idVisiteur"], (DateTime)r["mois"], (string)r["idFraisForfait"], (decimal)r["quantite"]));
            }
            return listLigneFraisForfait;
        }

        public LigneFraisForfait SelectById(string idFraisForfait)
        {
            DataRow result = this._dbal.SelectById("ligneFraisForfait", "idFraisForfait = " + idFraisForfait);
            return new LigneFraisForfait((string)result["idVisiteur"], (DateTime)result["mois"], (string)result["idFraisForfait"], (decimal)result["quantite"]);
        }

        public List<LigneFraisForfait> SelectByFicheFrais(FicheFrais uneFicheFrais)
        {
            List<LigneFraisForfait> listLigneFraisForfait = new List<LigneFraisForfait>();
            DataTable myTable = this._dbal.SelectByComposedFK2("ligneFraisForfait", "idVisiteur", uneFicheFrais.UnVisiteur.Id,"mois",uneFicheFrais.Mois);

            foreach (DataRow r in myTable.Rows)
            {
                listLigneFraisForfait.Add(new LigneFraisForfait((string)r["idVisiteur"], (DateTime)r["mois"], (string)r["idFraisForfait"], (decimal)r["quantite"]));
            }
            return listLigneFraisForfait;


        }
    }
}
