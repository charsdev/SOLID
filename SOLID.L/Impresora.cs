using System;

namespace SOLID.L
{

    public class Impresora
    {
        public void ImprimirRemito(Remito remito)
        {
            Console.WriteLine(remito.Description());
        }

        public void Imprimir(DocumentoContable factura)
        {
            Console.WriteLine(factura.Description());
        }
    }
}
