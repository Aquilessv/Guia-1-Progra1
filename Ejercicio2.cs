class Ejercicio2
{
    /*
     Usuario: PROGRA1 
     Password: K0m1d4.
     */
    public static void Main(string[] args)
    {
        string usuario, contrasena, mensaje;
        int cont = 1; //contador

        Console.WriteLine("Bienvenido al sistema! :) Inicie Sesion...");
        while (cont <= 3) {
            Console.WriteLine("-> Ingrese su usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine("-> Ingrese su contraseña:");
            contrasena = Console.ReadLine();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena)){
                Console.WriteLine("Usuario o Contraseña Vacios. Debe ingresar sus credenciales correctamente!");
                cont++;
                mensaje = cont > 3 ? "Limite de oportunidades alcanzado!\nRegrese pronto..." : "* Intentelo de nuevo";
                Console.WriteLine(mensaje);
            }
            else{
                if(usuario == "PROGRA1" && contrasena == "K0m1d4")
                {
                    Console.WriteLine("*** Bienvenido a ingresado al sistema! ***");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR: Credenciales incorrectas!!\n");
                    cont++;
                    mensaje = cont > 3 ? "Limite de oportunidades alcanzado!\nRegrese pronto..." : "* Intentelo de nuevo";
                    Console.WriteLine(mensaje);
                }
            }
        }
    }
}