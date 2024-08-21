try
{
    Console.WriteLine("Ingrese el año inicial:");
    int anioInicial = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el año final:");
    int anioFinal = Convert.ToInt32(Console.ReadLine());

    if (anioFinal < anioInicial)
    {
        Console.WriteLine("Error: el año final debe ser mayor o igual que el año inicial.");
        return;
    }

    Console.WriteLine("\nAños bisiestos entre " + anioInicial + " y " + anioFinal + ":");

    for (int anio = anioInicial; anio <= anioFinal; anio++)
    {
        if (EsBisiesto(anio))
        {
            Console.WriteLine(anio);
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Error, debe ingresar un número válido.");
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrió un error: " + ex.Message);
}

static bool EsBisiesto(int anio)
{
    if (anio % 4 == 0)
    {
        if (anio % 100 == 0)
        {
            if (anio % 400 == 0)
            {
                return true; // Es bisiesto
            }
            return false; // No es bisiesto
        }
        return true; // Es bisiesto
    }
    return false; // No es bisiesto
}

Console.ReadKey();
