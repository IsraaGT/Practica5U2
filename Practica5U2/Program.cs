Console.Write("Ingresa el número mínimo del rango: ");
int min, max;
min = int.Parse(Console.ReadLine());
Console.Write("Ingresa el número máximo del rango: ");
max = int.Parse(Console.ReadLine());
if (min >= max)
{
    Console.WriteLine("El número mínimo debe ser menor que el número máximo.");
}
else
{
    Random aleatorio = new Random();
    int numeroGenerado = aleatorio.Next(min, max + 1);
    Console.WriteLine($"Número aleatorio generado entre {min} y {max}: {numeroGenerado}");
}
Console.ReadKey();