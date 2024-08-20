
        try
        {
            Console.WriteLine("Ingrese el año inicial:");
            int añoInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el año final:");
            int añoFinal = Convert.ToInt32(Console.ReadLine());

            if (añoFinal < añoInicial)
            {
                Console.WriteLine("El año final debe ser mayor o igual que el año inicial.");
                return;
            }

            Console.WriteLine($"Años bisiestos entre {añoInicial} y {añoFinal}:");

            for (int año = añoInicial; año <= añoFinal; año++)
            {
                if (EsBisiesto(año))
                {
                    Console.WriteLine(año);
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    

    static bool EsBisiesto(int año)
    {
        if (año % 4 == 0)
        {
            if (año % 100 == 0)
            {
                if (año % 400 == 0)
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