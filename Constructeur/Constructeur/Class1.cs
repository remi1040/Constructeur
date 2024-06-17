using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Constructeur
{
    internal class Building
    {
        public int NombreEtages { get; set; }
        public int Hauteur { get; set; }
        public Building(int nombreEtage, int hauteur) 
        {
            this.NombreEtages = nombreEtage;
            this.Hauteur = hauteur;
        }

        public Building(int nombreEtage) 
        {
            this.NombreEtages = nombreEtage;
            this.Hauteur = this.NombreEtages * 3;
        }

        public int GetFloorMaxSize()
        {
            return this.Hauteur / this.NombreEtages;
        }

        public int GetFloorCount() 
        {
            return this.NombreEtages;
        }

        public int GetSize() 
        {
            return this.Hauteur;
        }

    }
}
