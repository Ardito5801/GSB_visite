using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBFrais.Model.Business
{
    public class Visiteur
    {
        //c'est un attribut)
        private string _id;
        private string _prenom;
        private string _nom;
        private string _login;
        private string _mdp;
        private string _adresse;
        private string _cp;
        private string _ville;
        private DateTime _dateEmbauche;

        public Visiteur(string unId, string unPrenom, string unNom, string unLogin, string unMdp, string uneAdresse, string unCp, string uneVille, DateTime uneDateEmbauche)
        {
            this._id = unId;
            this._prenom = unPrenom;
            this._nom = unNom;
            this._login = unLogin;
            this._mdp = unMdp;
            this._adresse = uneAdresse;
            this._cp = unCp;
            this._ville = uneVille;
            this._dateEmbauche = uneDateEmbauche;
        }

        //Propriétés

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        public string Mdp
        {
            get
            {
                return _mdp;
            }

            set
            {
                _mdp = value;
            }
        }

        public string Adresse
        {
            get
            {
                return _adresse;
            }

            set
            {
                _adresse = value;
            }
        }

        public string Cp
        {
            get
            {
                return _cp;
            }

            set
            {
                _cp = value;
            }
        }

        public string Ville
        {
            get
            {
                return _ville;
            }

            set
            {
                _ville = value;
            }
        }

        public DateTime DateEmbauche
        {
            get
            {
                return _dateEmbauche;
            }

            set
            {
                _dateEmbauche = value;
            }
        }
    }
}
