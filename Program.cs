using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<decimal, string> denominaciones = new Dictionary<decimal, string>()
        {
            {2000m, "billete de RD$2000 pesos"},
            {1000m, "billete de RD$1000 pesos"},
            {500m, "billete de RD$500 pesos"},
            {200m, "billete de RD$200 pesos"},
            {100m, "billete de RD$100 pesos"},
            {50m, "billete de RD$50 pesos"},
            {25m, "moneda de RD$25 pesos"},
            {10m, "moneda de RD$10 pesos"},
            {5m, "moneda de RD$5 pesos"},
            {1m, "moneda de RD$1 peso"}
        };

        Console.WriteLine("Ingrese el valor deseado: ");
        decimal valor = ObtenerValor();

        Console.WriteLine("Cantidad de billetes y monedas requeridas:");

        foreach (KeyValuePair<decimal, string> denominacion in denominaciones)
        {
            decimal cantidad = Math.Floor(valor / denominacion.Key);
            if (cantidad > 0)
            {
                Console.WriteLine($"{cantidad} {denominacion.Value}");
                valor %= denominacion.Key;
            }
        }
    }

    public static decimal ObtenerValor()
    {
        string input = Console.ReadLine();
        decimal valor;
        while (!decimal.TryParse(input, out valor) || valor < 0)
        {
            Console.WriteLine("Ingrese un valor válido: ");
            input = Console.ReadLine();
        }
        return valor;
    }
}
