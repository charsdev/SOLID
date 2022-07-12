using System;

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

            impresora.Imprimir(factura);
            impresora.Imprimir(notaCredito);
            impresora.Imprimir(remito);
            impresora.Imprimir(facturaLuz);
            impresora.Imprimir(municipal);

            Console.ReadKey();
        }
    }
}
