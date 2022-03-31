using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBFrais.Model.Business;
using GSBFrais.Model;

namespace GSB_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dbal unDbal = new Dbal("gsb_frais");
            DaoVisiteur unDaoVisiteur = new DaoVisiteur(unDbal);
            DaoEtat unDaoEtat = new DaoEtat(unDbal);
            DaoFicheFrais uneDaoFicheFrais = new DaoFicheFrais(unDbal, unDaoVisiteur, unDaoEtat);

            //SELECT BY MONTH FICHE FRAIS
            //List<FicheFrais> desFicheFrais = uneDaoFicheFrais.SelectByMonth("202001");
            //foreach (FicheFrais uneFicheFrais in desFicheFrais)
            //{
            //    Console.WriteLine(uneFicheFrais.NbJustificatifs);
            //}
            //Console.ReadKey();

            //SELECT BY ID VISITEUR
            //Visiteur unVisiteur = unDaoVisiteur.SelectById("a17");
            //Console.WriteLine(unVisiteur.Prenom);
            //Console.ReadKey();

            //SELECT ALL FICHE FRAIS
            List<FicheFrais> desFicheFrais = uneDaoFicheFrais.SelectAll();
            foreach (FicheFrais uneFicheFrais in desFicheFrais)
            {
                Console.WriteLine(uneFicheFrais.MontantValide);
            }
            Console.ReadKey();



        }
    }
}