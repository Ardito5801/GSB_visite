using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GSBFrais.Model;
using GSBFrais.Model.Business;
using GSBFrais.Model.Data;
using GSB_Console;
using WpfGSBFrais;

namespace WpfGSBFrais
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DaoFicheFrais theDaoFicheFrais;
        public MainWindow(DaoFicheFrais uneDaoFicheFrais)
        {
            theDaoFicheFrais = uneDaoFicheFrais;
            InitializeComponent();
            MainGrid.DataContext = new ViewModel.ViewModelMainWindow(theDaoFicheFrais);
            
        }
    }
}
