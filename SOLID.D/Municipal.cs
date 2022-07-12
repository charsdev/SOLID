using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class Municipal : Impuesto
    {
        public Municipal(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }
        public string Partida { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Impuesto Municipal {Partida} con valor de {Importe}");
        }
    }

}
