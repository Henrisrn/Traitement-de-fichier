using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bopp_traitement_de_fichier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finir algo pour traiter et faire les devis
            /* DESCRIPTION DE L'ALGO 
            ON SPLIT LE DOC CSV EN PLUSIEURS SOUS TABLEAU 
            GRAND TABLEAU = N° de LIGNE
            SOUS TABLEAU = Colonne de la ligne*/

            string contenu2 = File.ReadAllText("Assainissement.csv");
            //string [] cases = contenu2.Split('"');
            
            string[] ligne = contenu2.Split('\n');
            string[] a = ligne[0].Split(';');
            string[,] casetotal = new string[ligne.Length,a.Length];
            a = null;
            for (int i = 0; i < ligne.Length;i++)
            {
                
                a = ligne[i].Split(';');
                for(int j = 0;j<a.Length;j++)
                {
                    casetotal[i, j] = a[j];
                    //Console.Write("   case [i = " + i + ", j = " + j + " = "+casetotal[i, j]);
                }
                //Console.WriteLine();
            }
            for (int i = 0; i < casetotal.GetLength(0); i++)
            {
                string[] spl = casetotal[i, 0].Split(' ');
                if (spl.Length >= 2)
                {
                    string t = null;
                    for (int j = 5; j < spl.Length; j++)
                    {

                        if (spl[j] != "?")
                        {
                            t += spl[j] + " ";
                        }
                    }




                    casetotal[i, 0] = spl[0];
                    casetotal[i, 1] = t;
                }
                
            }
            /*
             * 
             * AFFICHAGE DE LA BASE DE DONNEE RECOLTER
             * 
             */ 
            for (int i = 0; i < casetotal.GetLength(0); i++)
            {
                for(int j = 0;j<casetotal.GetLength(1);j++)
                {
                    Console.Write(" j = " + j + " "+casetotal[i, j] + "  ");
                }
                Console.WriteLine();
            }
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
            
            Console.Write("Nom pour le devis :  ");
            string nom = Console.ReadLine();
            Console.Write("Prénom pour le devis :  ");
            string prenom = Console.ReadLine();
            Devis test = new Devis(nom, prenom,casetotal);


            Console.ReadLine();
        }
    }
}
