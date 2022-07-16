using System;
using System.Collections.Generic;

namespace SOLID.D
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();
            Factura factura = new Factura(DateTime.Now, 1234,303);
            NotaCredito notaCredito = new NotaCredito(DateTime.Now, 344, 404);
            Remito remito = new Remito(5551, DateTime.Now, 5);
            FacturaLuz facturaLuz = new FacturaLuz(441, "444545");
            Municipal municipal = new Municipal(1221, "55555662");

            List<IImprimible> imprimibles = new List<IImprimible>();
            imprimibles.Add(factura);
            imprimibles.Add(notaCredito);
            imprimibles.Add(remito);
            imprimibles.Add(facturaLuz);
            imprimibles.Add(municipal);

            foreach (var imprimible in imprimibles)
            {
                impresora.Imprimir(imprimible);
            }

            Console.ReadKey();
        }
    }
}
