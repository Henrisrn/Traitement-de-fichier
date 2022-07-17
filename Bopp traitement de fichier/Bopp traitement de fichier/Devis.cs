using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bopp_traitement_de_fichier
{
    class Devis
    {
        private string NomC;
        private string PrenomC;
        private int Prixdevis;
        private List<LignedeDevis> Res;
        private string[,] basedeprix;
        public Devis(string nom,string prenom,string[,]basedeprix)
        {
            this.NomC = nom;
            this.PrenomC = prenom;
            this.basedeprix = basedeprix;
            Res = new List<LignedeDevis>();
            
        }
        public void AjouterLigne(int re)
        {
            /* j = 0 : Référence
           j = 1 : Noms du service
           j = 4 : Temps de pose
           j = 6 : Prix de la pause (temps de pose * Tarif horaire)
           j = 8 : ¨Prix de la pause pour personne qualifié
           j = 9 : Prix fourniture/ Matos
           j = 10 : Prix fourniture + pause (pas qualifié)
           j = 11 : Prix fourniture + pause pro
           j = 2 : Pas utile
           */
            Console.Write("Entrez le nom du service : ");
            string a = Console.ReadLine();
            //double c = 0;
            
            if(Double.TryParse(a, out c))
            {
                //Le nombre entré est une ref
                for(int  i = 0;i<basedeprix.GetLength(0);i++)
                {
                    string[] o = basedeprix[i, 0].Split('.');
                    
                }
            }
            else
            {
            //Le nombre entré est un nom
            for(int i = 0;i<basedeprix.GetLength(0);i++)
                {
                    if(basedeprix[i,1] == a)
                    {
                        break;
                    }
                }
            LignedeDevis a = new LignedeDevis();
            Res.Add(a);
        }
        public void RetirerLigne(int re)
        {
            
        }
        
    }
}
