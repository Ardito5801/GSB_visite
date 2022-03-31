using GSBFrais.Model.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBFrais.Model
{
    public class DaoEtat
    {
        private Dbal _dbal;

        public DaoEtat(Dbal leDbal)
        {
            this._dbal = leDbal;
        }
        
        public List<Etat> SelectAll()
        {
            List<Etat> listEtat = new List<Etat>();
            DataTable myTable = this._dbal.SelectAll("Etat");

            foreach (DataRow r in myTable.Rows)
            {
                listEtat.Add(new Etat((string)r["id"], (string)r["libelle"]));
            }
            return listEtat;
        }

        public Etat SelectById(string unId)
        {
            DataRow result = this._dbal.SelectById("Etat", unId);
            return new Etat((string)result["id"], (string)result["libelle"]);
        }
    }
}
