//programa básico de consola
Console.Write("INGRESA LOS DATOS REQUERIDOS");

Console.WriteLine(" ");
//Solicitud de datos al usuario
//entrada de datos & almacenamiento
Console.Write("Nombre:");
string nombre = Console.ReadLine();

Console.Write("Apellido:");
string apellido = Console.ReadLine();

Console.Write("Edad:");
int edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Altura:");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Hola, mi nombre es {nombre} {apellido}, tengo {edad} años de edad y mido {altura} metros de altura.");
//Salida de datos