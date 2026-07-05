//Tipos de datos 
int edad = 23;

double temperatura = 32.5;

bool esAdmin = false;

char tipoSangre = 'A';

string mensaje = "Hola muchachos";

int[] numeros = { 1, 2, 3 };

List<string> nombre = new List<string> { "Samuel", "Maria", "Jose"};

Dictionary<int, string> diccionario = new Dictionary<int, string> 
{
    {1, "Papa" }, {2, "Cebolla"}   
};

HashSet<string> letras = new HashSet<string> { "A", "B", "C", "A" };

Console.WriteLine(numeros[0]);
Console.WriteLine(diccionario[1]);
Console.WriteLine(letras.Count());

(int, string) empleado = (1, "Juan"); 

Console.WriteLine("Tupla: " + empleado.Item1 + " " + empleado.Item2);

Carro carro1 = new Carro(1, "Susuki");

carro1.acelerar(2);

const double PI = 3.1415;

int num1 = 150;

Console.WriteLine($" El resultado es un char {Convert.ToChar(150).GetType()}");

var variable1 = 120.00;

Console.WriteLine(variable1.GetType());

string? mensaje1 = null;

int? longitud = mensaje1?.Length;

if (longitud.HasValue)
{
    Console.WriteLine("tiene valor");
}
else
{
    Console.WriteLine("no tiene valor");
}

int dia = 3;

switch (dia)
{
    case 1:
        Console.WriteLine("Es lunes");
        break;
    case 2:
        Console.WriteLine("Es martes");
        break;
    case 3:
        Console.WriteLine("Es miercoles");
        break;
}





class Persona
{
    public string Nombre {  get; set; }
    public int Edad { get; set; }
}

struct Punto
{
    public int X { get; set; }
    public int Y { get; set; }
}

record PersonaDTO(int Id, string Nombre) { };

class Carro : ICarro
{
    public int Id { get; set; }
    public string Marca { get; set;  }

    public Carro(int Id, string Marca)
    {
        this.Id = Id;
        this.Marca = Marca;
    }

    public void acelerar(int velocidad)
    {
        Console.WriteLine($"Estoy acelerando a {velocidad} km");
    }
}

interface ICarro
{
    public void acelerar(int velocidad);
}