using System;

namespace SOLID.I
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura(DateTime.Now, 12344);
            factura.CAI = "234543";
            FacturaElectronica facturaElectronica = new FacturaElectronica(DateTime.Now, 12344);
            factura.CAI = "66666534";

            factura.Imprimir();
            facturaElectronica.EnviarPorMail();
            facturaElectronica.Imprimir();

            Console.ReadKey();
        }
    }
}
