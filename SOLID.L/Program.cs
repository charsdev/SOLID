using System;

namespace SOLID.L
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();
            Remito remito = new Remito(10, 3331, DateTime.Now);
            DocumentoContable factura = new Factura(DateTime.Now, 66423);
            DocumentoContable notaCredito = new NotaCredito(DateTime.Now, 441);
            DocumentoContable notaDebito = new NotaDebito(DateTime.Now, 441);

            impresora.ImprimirRemito(remito);
            impresora.Imprimir(factura);
            impresora.Imprimir(notaCredito);
            impresora.Imprimir(notaDebito);

            Console.ReadKey();
        }
    }
}
