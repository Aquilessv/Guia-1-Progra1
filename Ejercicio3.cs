class Ejerccio3
{
    static void Main(string[] args)
    {

        int nume;
        bool numeroValido = false;

        while (!numeroValido)

            //solicitar al usuario ingresar un numero
            Console.WriteLine("Ingrese un numero");
        string num = Console.ReadLine();
        int numero;
        //int numero = int.Parse(Console.ReadLine());

        if (String.IsNullOrEmpty(num))
        {
            Console.WriteLine("Ingrese un numero");
            num = Console.ReadLine();
            numero = int.Parse(num);
            String resultado = (numero > 0) ? "Positivo" : (numero < 0) ? "Negativo" : "Cero";

            //Mostrar el resultado
            Console.WriteLine("El numero ingresado es: " + resultado);

        }
        else
        {
            numero = int.Parse(num);
            //Operador termario para determinar si el numero es positivo, negativo o cero.
            String resultado = (numero > 0) ? "Positivo" : (numero < 0) ? "Negativo" : "Cero";

            //Mostrar el resultado
            Console.WriteLine("El numero ingresado es: " + resultado);
        }

        Console.ReadKey();
    }
}
