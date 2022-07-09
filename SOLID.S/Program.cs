using System;

namespace SOLID.S
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.Apellido = "Lopez";
            c.Nombre = "Diego";

            Factura f = new Factura(21332, c);

            Producto producto1 = new Producto("Arroz", 10);
            Producto producto2 = new Producto("Queso", 90);
            Producto producto3 = new Producto("Gaseosa", 70);

            Item i1 = new Item(producto1, 5);
            Item i2 = new Item(producto2, 1);
            Item i3 = new Item(producto3, 2);

            f.Items.Add(i1);
            f.Items.Add(i2);
            f.Items.Add(i3);

            Console.WriteLine(f.Total());
            Console.ReadKey();
        }
    }
}
