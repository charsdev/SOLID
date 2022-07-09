using System;

namespace SOLID.O
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentoContable factura = new Factura(14312);
            Console.WriteLine(factura.Descripcion());
            DocumentoContable notaCredito = new NotaCredito(14312);
            Console.WriteLine(notaCredito.Descripcion());
            DocumentoContable notaDebito = new NotaDebito(14312);
            Console.WriteLine(notaDebito.Descripcion());
            Console.ReadKey();
        }
    }
}
