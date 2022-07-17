using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bopp_traitement_de_fichier
{
    class LignedeDevis
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
        private string refe;
        private string nomServ;
        private double temppose;
        private double prixpose;
        private double prixfourniture;
        private double total;
        public LignedeDevis(string refe,string nomServ,double tempose,double prixpose,double prixfourniture)
        {
            this.refe = refe;
            this.nomServ = nomServ;
            this.temppose = tempose;
            this.prixpose = prixpose;
            this.prixfourniture = prixfourniture;
            this.total = (prixpose + prixfourniture)*1.25;
        }
        public void RenduLigne()
        {
            Console.WriteLine(" Referance = " + refe+" ; Nom du Service = "+nomServ+" ; Temps nécessaires pour pause = "+temppose+" ; Prix de la pause = "+prixpose+" ; Prix du matériel nécessaires  = "+prixfourniture+" ; TOTAL (TTC) = "+total);
        }

    }
}
