using System;

namespace SOLID.L
{
    public class Remito 
    { 
        public int CantidadDeBultos;
        private int _numero;
        private DateTime _fecha;

        public Remito(int cantidadDeBultos, int numero, DateTime fecha)
        {
            CantidadDeBultos = cantidadDeBultos;
            _numero = numero;
            _fecha = fecha;
        }

        public string Imprimir()
        {
            return $"Imprimiendo {Description()}";
        }

        public string Description() 
        {
            return $"Remito nro {_numero} de Fecha {_fecha.ToShortDateString()} " +
                $"con {CantidadDeBultos}";
        } 
    }

}
