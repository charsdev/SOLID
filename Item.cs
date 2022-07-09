namespace SOLID.S
{
    public class Item
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public double SubTotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}
