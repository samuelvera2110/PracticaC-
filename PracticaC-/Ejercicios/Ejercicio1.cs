namespace Ejercicios
{
    internal class Ejercicio1
    {
        public static void Ejecutar()
        {
            try
            {
                string mensaje = string.Empty;

                Console.WriteLine("Ingresa la calificacion del estudiante (0 - 100): ");

                //Manejar con punto decimal
                //double? calificacion = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                double? calificacion = Convert.ToDouble(Console.ReadLine());

                if (!calificacion.HasValue || calificacion < 0 || calificacion > 100)
                {
                    throw new Exception("Calificación no válida");
                }

                switch (calificacion)
                {
                    case >= 0 and <= 59:
                        mensaje = "Reprobado";
                        break;
                    case >= 60 and <= 89:
                        mensaje = "Necesita mejorar";
                        break;
                    case >= 90 and <= 100:
                        mensaje = "Aprobado";
                        break;
                }

                Console.WriteLine($"{mensaje} con nota: {calificacion}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");

                /*foreach (DictionaryEntry entry in ex.Data)
                {
                    Console.WriteLine($"{entry.Key}, {entry.Value}");
                }*/
            }

        }
    }
}

