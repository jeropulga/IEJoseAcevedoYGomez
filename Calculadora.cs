Console.WriteLine("Escriba un número");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba otro número");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Número 1:Suma");
Console.WriteLine("Número 2:Resta");
Console.WriteLine("Número 3: multiplicación");
Console.WriteLine("Número 4 división");
int respuesta = Convert.ToInt32(Console.ReadLine());
switch (respuesta)
{
    case 1:
        Console.WriteLine($"suma: {num1 + num2}");
        break;
    case 2:
        Console.WriteLine($"resta: {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"Multiplicación: {num1 * num2}");
        break;
    case 4:
        Console.WriteLine($"División: {num1 / num2}");
        break;
    default:
        Console.WriteLine("Opción no existente");
        break;
