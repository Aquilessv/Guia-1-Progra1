class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Operaciones");
        Console.Write("\nIngrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la clave (+, -, *, /, R, E): ");
        char clave = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Salto de línea

        double resultado = 0, resultado2 = 0;

        switch (clave)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Error: No se puede dividir entre 0.");
                break;
            case 'R':
                resultado = Math.Sqrt(num1);
                resultado2 = Math.Sqrt(num2);
                break;
            case 'E':
                resultado = Math.Pow(num1, num2);
                resultado = Math.Round(resultado, 3); // Redondear a 3 decimales
                break;
            default:
                Console.WriteLine("Clave no válida. Intente nuevamente.");
                break;
        }

        if (resultado2 != 0)
            Console.WriteLine("Resultado 1: " + resultado + "\nResultado 2: " + resultado2);
        else
            Console.WriteLine($"\nResultado: {resultado}");

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
