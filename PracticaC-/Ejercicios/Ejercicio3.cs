namespace Ejercicios
{
    internal class Ejercicio3
    {
        public static void Ejecutar()
        {
            List<Producto> listaProductos = new List<Producto>
            {
                new Producto("Laptop", 1200.50m, 10),
                new Producto("Mouse", 25.99m, 50),
                new Producto("Teclado Mecánico", 89.99m, 20),
                new Producto("Monitor 24\"", 199.99m, 15),
                new Producto("Auriculares", 59.99m, 30)
            };

            List<Producto> resultados = listaProductos
                .Where(p => p.Precio > 50m)
                .OrderBy(p => p.Precio)
                .ToList();

            foreach (var producto in resultados)
            {
                producto.GetDetalles();
            }
        }

    }

        class Producto(string Nombre, decimal Precio, int Stock)
        {
            public string Nombre { get; set; } = Nombre;
            public decimal Precio { get; set; } = Precio;
            public int Stock {  get; set; } = Stock;

            public void GetDetalles()
            {
                foreach (var prop in typeof(Producto).GetProperties())
                {
                    Console.WriteLine($"{prop.Name} : {prop.GetValue(this)}");
                }
            }
        }

    
}
