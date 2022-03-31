using GSBFrais.Model.Business;
using GSBFrais.Model.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBFrais.Model
{
    public class DaoFicheFrais
    {
        private Dbal _dbal;
        private DaoVisiteur _daoVisiteur;
        private DaoEtat _daoEtat;
        private DaoLigneFraisForfait _daoLigneFraisForfait;
        private DaoLigneFraisHorsForfait _daoLigneFraisHorsForfait;

        public DaoFicheFrais(Dbal unDbal, DaoVisiteur unDaoVisiteurs, DaoEtat unDaoEtat)
        {
            this._dbal = unDbal;
            this._daoVisiteur = unDaoVisiteurs;
            this._daoEtat = unDaoEtat;
        }
        //public void Insert(FicheFrais uneFicheFrais)
        //{
        //    string query = "fichefrais (idVisiteur, mois, nbJustificatifs, montantValide, dateModif) VALUES ('" + uneFicheFrais.UnVisiteur.Id + "', '" + uneFicheFrais.Mois + "', " + uneFicheFrais.NbJustificatifs + ", " + uneFicheFrais.MontantValide.ToString(CultureInfo.GetCultureInfo("en-GB")) + ", '" + uneFicheFrais.DateModif.Date.ToString("yyyy-MM-dd") + "')";
        //    this._dbal.Insert(query);
        //}
        public void Delete(FicheFrais uneFicheFrais)
        {
            string query = "fichefrais where idVisiteur = '" + uneFicheFrais.UnVisiteur.Id + "' and mois = '" + uneFicheFrais.Mois + "'";
            this._dbal.Delete(query);
        }
        public void Update(FicheFrais uneFicheFrais)
        {
            string query = "fichefrais SET " + "idVisiteur = '" + uneFicheFrais.UnVisiteur.Id + "' , mois = '" + uneFicheFrais.Mois + "' , nbJustificatifs = '" + uneFicheFrais.NbJustificatifs + "' , montantValide = '" + uneFicheFrais.MontantValide + "' , dateModif = '" + uneFicheFrais.DateModif + "' , idEtat = '" + uneFicheFrais.UnEtat.Id;
            this._dbal.Update(query);
        }

        public bool SelectByMonth(object v)
        {
            throw new NotImplementedException();
        }

        public List<FicheFrais> SelectAll()
        {
            List<FicheFrais> listeFicheFrais = new List<FicheFrais>();
            DataTable maTable = this._dbal.SelectAll("fichefrais");
            foreach (DataRow r in maTable.Rows)
            {

                Visiteur leVisiteur = _daoVisiteur.SelectById((string)r["idVisiteur"]);
                Etat unEtat = _daoEtat.SelectById((string)r["idEtat"]);
                listeFicheFrais.Add(new FicheFrais(leVisiteur, (string)r["mois"], unEtat, (decimal)r["montantvalide"], (int)r["nbJustificatifs"], (DateTime)r["dateModif"]));
            }
            return listeFicheFrais;
        }
        //SELECT DISTINCT(mois) FROM Fichefrais OrderBY mois desc
        public List<FicheFrais> SelectByMonth(string moisFiche)
        {
            List<FicheFrais> listeFicheFrais = new List<FicheFrais>();
            DataTable maTable = new DataTable();
            DaoVisiteur daoVisiteur = new DaoVisiteur(_dbal);
            maTable = this._dbal.SelectByField("fichefrais", "mois = '" + moisFiche + "'");
            foreach (DataRow r in maTable.Rows)
            {

                Visiteur leVisiteur = _daoVisiteur.SelectById((string)r["idVisiteur"]);
                Etat unEtat = _daoEtat.SelectById((string)r["idEtat"]);
                listeFicheFrais.Add(new FicheFrais(leVisiteur, (string)r["mois"], unEtat, (decimal)r["montantvalide"], (int)r["nbJustificatifs"], (DateTime)r["dateModif"]));
            }
            return listeFicheFrais;
        }

    }
}

