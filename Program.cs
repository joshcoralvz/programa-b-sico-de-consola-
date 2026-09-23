//programa básico de consola
Console.Write("INGRESA LOS DATOS REQUERIDOS");

Console.WriteLine(" ");

Console.Write("Nombre:");
string nombre = Console.ReadLine();

Console.Write("Apellido:");
string apellido = Console.ReadLine();

Console.Write("Edad:");
int edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Altura:");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Hola, mi nombre es {nombre} {apellido}, tengo {edad} años de edad y mido {altura} metros de altura.");
