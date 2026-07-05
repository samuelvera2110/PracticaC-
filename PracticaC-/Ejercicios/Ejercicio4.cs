using System.Runtime.CompilerServices;

namespace Ejercicios
{
    internal class Ejercicio4
    {
        public static void Ejecutar()
        {
            List<Empleado> listaEmpleados = new List<Empleado>
            {
                new Empleado("Ana Pérez", "Recursos Humanos", 1500.00m),
                new Empleado("Carlos Gómez", "Finanzas", 2000.50m),
                new Empleado("María Torres", "IT", 2500.75m),
                new Empleado("Luis Fernández", "Marketing", 1800.00m),
                new Empleado("Sofía Ramírez", "Ventas", 2200.00m)
            };

            List <(string Departamento, decimal PromedioSalarial, int CantEmpleados)> resultados = 
                listaEmpleados
                .GroupBy(e => e.Departamento)
                .Select(g => (g.Key, g.Average(e => e.Salario), g.Count()))
                .ToList();

            foreach (var emp in resultados)
            {
                Console.WriteLine($"{emp.Departamento} {emp.CantEmpleados} {emp.PromedioSalarial}");
            }

        }


        class Empleado(string Nombre, string Departamento, decimal Salario)
        {
            public string Nombre { get; set; } = Nombre;
            public string Departamento { get; set; } = Departamento;
            public decimal Salario { get; set; } = Salario;

        }

    }
}
