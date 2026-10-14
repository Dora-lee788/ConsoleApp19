using System;
using System.Collections.Generic;

class ListOfEdges
{
    public static void Show()
    {
        string[] stops =
        {
            "Центральный вокзал",
            "Площадь",
            "Университет",
            "Больница",
            "Торговый центр",
            "Аэропорт"
        };

        List<(int From, int To, int Weight)> edges =
            new List<(int From, int To, int Weight)>
        {
            (0, 1, 5),
            (0, 2, 12),
            (1, 2, 4),
            (1, 3, 8),
            (2, 3, 3),
            (2, 4, 7),
            (3, 4, 4),
            (3, 5, 15),
            (4, 5, 6),
            (4, 0, 10)
        };

        Console.WriteLine("\nСписок рёбер:");

        foreach (var edge in edges)
        {
            Console.WriteLine(
                stops[edge.From] + " -> " +
                stops[edge.To] + ", время: " +
                edge.Weight + " мин.");
        }
    }
}