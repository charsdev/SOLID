using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{

    public class ReciboSueldo : IImprimible
    {
        public ReciboSueldo(double total, int legajo)
        {
            Total = total;
            Legajo = legajo;
        }

        public double Total { get; set; }
        public int Legajo { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Recibo de Sueldo {Legajo} con valor de {Total}");
        }
    }
}
