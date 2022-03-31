using GSBFrais.Model.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBFrais.Model
{
    public class DaoVisiteur
    {
        private Dbal _dbal;

        public DaoVisiteur(Dbal leDbal)
        {
            this._dbal = leDbal;
        }
        public List<Visiteur> SelectAll()
        {
            List<Visiteur> listVisiteur = new List<Visiteur>();
            DataTable myTable = this._dbal.SelectAll("Visiteur");

            foreach (DataRow r in myTable.Rows)
            {
                listVisiteur.Add(new Visiteur((string)r["id"], (string)r["prenom"], (string)r["nom"], (string)r["login"], (string)r["mdp"], (string)r["adresse"], (string)r["cp"], (string)r["ville"], (DateTime)r["dateEmbauche"]));
            }
            return listVisiteur;
        }

        public Visiteur SelectById(string unId)
        {
            DataRow result = this._dbal.SelectById("Visiteur", unId);
            return new Visiteur((string)result["id"], (string)result["prenom"], (string)result["nom"], (string)result["login"], (string)result["mdp"], (string)result["adresse"], (string)result["cp"], (string)result["ville"], (DateTime)result["dateEmbauche"]);
        }
    }
}
