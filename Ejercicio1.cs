class Ejercicio1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite dos numeros porfavor:");

        int num1 = 0;
        int num2 = 0;
        int numero;

        Console.WriteLine("Digite el primer numero");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Porfavor digite el segundo numero");
        num2 = int.Parse(Console.ReadLine());

        int numeroM = Math.Max(num1, num2);

        Console.WriteLine("El numero mayor es :" + " " + numeroM);
        Console.WriteLine("======================================================================\n");
        Console.WriteLine("Digite un numero entero positivo que quiera sacarle raiz cubica");

        while (true)
        {
            string NumeroI = Console.ReadLine();
            if (int.TryParse(NumeroI, out numero) && numero > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("EL dato es invalido porfavor ingrese un numero entero positivo");
            }
        }

        double raiz = Math.Pow(numero, 1.0 / 3.0);
        Console.WriteLine("La raiz cubica de" + " " + numero + " " + "es aproximadamente" + " " + raiz);

        Console.ReadKey();
    }
}

