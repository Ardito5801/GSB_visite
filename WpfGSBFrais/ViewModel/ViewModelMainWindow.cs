using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBFrais.Model;
using System.Collections.ObjectModel;
using GSBFrais.Model.Business;

namespace WpfGSBFrais.ViewModel
{
    public class ViewModelMainWindow
    {
        private ObservableCollection<FicheFrais> listFicheFrais;
        private DaoFicheFrais theDaoFicheFrais;
        private ObservableCollection<string> moisFicheFrais;
        private string selectedMonth;
        private FicheFrais selectedFicheFrais;
        private string repas;
        private string nuite;
        private string fraiskm;
        private string forfaitetape;
        public ObservableCollection<FicheFrais> ListFicheFrais
        {
            get
            {
                return listFicheFrais;
            }

            set
            {
                listFicheFrais = value;
            }
        }

        public ObservableCollection<string> MoisFicheFrais
        {
            get
            {
                return moisFicheFrais;
            }
            set
            {
                moisFicheFrais = value;
            }
        }
        

        public ViewModelMainWindow(DaoFicheFrais theDaoFicheFrais)
        {
            this.theDaoFicheFrais = theDaoFicheFrais;
            ListFicheFrais = new ObservableCollection<FicheFrais>(theDaoFicheFrais.SelectAll());

        }
    }
}
