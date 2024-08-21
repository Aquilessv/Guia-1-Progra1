class Ejercicio3
{
    static void Main(string[] args)
    {
        string num = string.Empty;
        int numero;
        bool numeroValido = false;

        while (numeroValido == false)
        {
            //solicitar al usuario ingresar un numero
            Console.WriteLine("Ingrese un numero: \n(No debe estar vacio ni ser letras)");
            num = Console.ReadLine();

            //validar si el valor ingresado esta vacio o nulo
            if (String.IsNullOrEmpty(num)){
                numeroValido = false;
            }else{
                numeroValido = true;
            }
        }

        try
        {
            numero = int.Parse(num);
            //Operador termario para determinar si el numero es positivo, negativo o cero.
            String resultado = (numero > 0) ? "Positivo" : (numero < 0) ? "Negativo" : "Cero";

            //Mostrar el resultado
            Console.WriteLine("\nEl numero ingresado es: " + resultado);
        }
        catch (Exception error) { 
            Console.WriteLine("\nERROR DE ENTRADA DE DATOS: " + error.Message);
        }

        Console.ReadKey();
    }
}
