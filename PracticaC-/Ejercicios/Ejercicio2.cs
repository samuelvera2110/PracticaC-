namespace Ejercicios
{
    internal class Ejercicio2
    {
        public static void Ejecutar()
        {
            Vehiculo[] vehiculos =
            {
                new Coche("Toyota", "Corolla", 2020, 4),
                new Motocicleta("Yamaha", "MT-07", 2021, "Deportivo")
            };

            foreach(var vehiculo in vehiculos)
            {
                vehiculo.MostrarDetalles();
                Console.WriteLine("-----------------------");
            }
        }

    }

    abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string Marca, string Modelo, int Anio)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Anio = Anio;
        }

        public abstract void MostrarDetalles();
    }

    class Coche(string Marca, string Modelo, int Anio, int NumeroPuertas) 
        : Vehiculo(Marca, Modelo, Anio)
    {
        public int NumeroPuertas { get; set; } = NumeroPuertas;

        public override void MostrarDetalles()
        {
            foreach (var prop in typeof(Coche).GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(this)}");
            }
        }
    }

    class Motocicleta(string Marca, string Modelo, int Anio, string TipoManillar) 
        : Vehiculo(Marca, Modelo, Anio)
    {
        public string TipoManillar { get; set; } = TipoManillar;

        public override void MostrarDetalles()
        {
            foreach (var prop in typeof(Motocicleta).GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(this)}");
            }
        }
    }

}
