using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class Impresora
    {
        public void Imprimir(IImprimible imprimible)
        {
            imprimible.Imprimir();
        }
    }
}
