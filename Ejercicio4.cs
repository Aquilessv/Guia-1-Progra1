bool continuar = true;

while (continuar)
{
    Console.WriteLine("Programa para encontrar años bisiestos en un rango dado.");

    int anioInicio = SolicitarAnio("\nIngrese el año de inicio del rango: ");
    int anioFin = SolicitarAnio("Ingrese el año de fin del rango: ");

    if (anioInicio > anioFin)
    {
        Console.WriteLine("\nEl año de inicio no puede ser mayor que el año de fin.");
    }
    else
    {
        Console.WriteLine($"\nAños bisiestos entre {anioInicio} y {anioFin}:");

        for (int anio = anioInicio; anio <= anioFin; anio++)
        {
            if (EsBisiesto(anio))
            {
                Console.WriteLine(anio);
            }
        }
    }

    continuar = DeseaContinuar();
}

static bool EsBisiesto(int anio)
{
    // Verifica si un año es bisiesto
    if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
    {
        return true;
    }
    return false;
}

static int SolicitarAnio(string mensaje)
{
    int anio;
    while (true)
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out anio))
        {
            return anio;
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un año válido.");
        }
    }
}

static bool DeseaContinuar()
{
    while (true)
    {
        Console.WriteLine("¿Desea continuar? (S/N): ");
        string respuesta = Console.ReadLine().Trim().ToUpper();

        if (respuesta == "S")
        {
            
            return true;
        }
        else if (respuesta == "N")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Respuesta no válida. Por favor, ingrese 'S' para Sí o 'N' para No.");
        }
    }
}

Console.ReadKey();
