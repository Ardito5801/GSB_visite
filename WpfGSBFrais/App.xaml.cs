using GSBFrais.Model;
using GSBFrais.Model.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfGSBFrais
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Dbal theDbal;
        private DaoEtat theDaoEtat;
        private DaoFicheFrais theDaoFicheFrais;
        private DaoLigneFraisForfait theDaoLigneFraisForfait;
        private DaoLigneFraisHorsForfait theDaoLigneFraisHorsForfait;
        private DaoVisiteur theDaoVisiteur;
        private DaoFraisForfait theDaoFraisForfait;

        public void Application_Startup(object sender, StartupEventArgs e)
        {
            theDbal = new Dbal("gsb_frais");
            theDaoEtat = new DaoEtat(theDbal);
            theDaoVisiteur = new DaoVisiteur(theDbal);
            theDaoFraisForfait = new DaoFraisForfait(theDbal);
            theDaoLigneFraisForfait = new DaoLigneFraisForfait(theDbal, theDaoVisiteur, theDaoLigneFraisForfait);
            theDaoLigneFraisHorsForfait = new DaoLigneFraisHorsForfait(theDbal, theDaoFraisForfait, theDaoVisiteur, theDaoFraisForfait);
            theDaoFicheFrais = new DaoFicheFrais(theDbal, theDaoVisiteur, theDaoEtat);

            MainWindow wnd = new MainWindow(theDaoFicheFrais);
            wnd.Show();
        }
    }
}
