namespace Ejercicios
{
    internal class Ejercicio5
    {
        public const string QUITO = "Quito";
        public const char START_WITH = 'M';

        public record ClientesResumen(int CantidadClientes, decimal SaldoTotal, decimal SaldoPromedio,
            Cliente? ClienteMayorSaldo, Cliente? ClienteMenorSaldo, List<Cliente> Top3Clientes);
        public static void Ejecutar()
        {
            List<Cliente> ClientesActivos = new List<Cliente>
            {
                new Cliente(1, "Ana Pérez", "Quito", 6000m),
                new Cliente(2, "Carlos Gómez", "Guayaquil", 4500m),
                new Cliente(3, "María Torres", "Quito", 7200m)
            };

            List<Cliente> ClientesInactivos = new List<Cliente>
            {
                new Cliente(1, "Ana Pérez", "Quito", 6000m),
                new Cliente(4, "Luis Fernández", "Cuenca", 2000m),
                new Cliente(5, "Sofía Ramírez", "Quito", 3500m),
                new Cliente(6, "Miguel Andrade", "Ambato", 1000m)
            };

            IEnumerable<Cliente> TodosLosClientes = ClientesActivos.Union(ClientesInactivos).ToList();

            IEnumerable<Cliente> ClientesSaldoMayor5000 = TodosLosClientes.Where(c => c.Saldo > 5000).ToList();

            IEnumerable<Cliente> ClientesConLetraM = TodosLosClientes.Where(c => c.Nombre.StartsWith(START_WITH)).ToList();

            IEnumerable<Cliente> ClientesQuito = TodosLosClientes.Where(c => c.Ciudad.Equals(QUITO)).ToList();

            var resumen = new ClientesResumen(
                TodosLosClientes.Count(),
                TodosLosClientes.Sum(c => c.Saldo),
                TodosLosClientes.Average(c => c.Saldo),
                TodosLosClientes.MaxBy(c => c.Saldo),
                TodosLosClientes.MinBy(c => c.Saldo),
                TodosLosClientes.OrderByDescending(c => c.Saldo).Take(3).ToList()
            );


        }

    }

    class Cliente(int Id, string Nombre, string Ciudad, decimal Saldo) : IEquatable<Cliente>
    {
        public int Id { get; set; } = Id;
        public string Nombre { get; set; } = Nombre;
        public string Ciudad { get; set; } = Ciudad;
        public decimal Saldo { get; set; } = Saldo;

        public bool Equals(Cliente? other)
        {
            if (other is null) return false;

            return this.Id == other.Id;
        }

        public override bool Equals(object? obj) => Equals(obj as Cliente);

        public override int GetHashCode() => Id.GetHashCode();

    }


    //class, struct (16 bytes), record 

}
