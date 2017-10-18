using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculCaisse.Library
{
    public class Monnaie
    {
        public double Valeur { get; set; }

        public Monnaie(double montant)
        {
            Valeur = montant;
        }

        public double Total(double nombre)
        {
            double result = Valeur * nombre;
            return result;
        }
    }
}
