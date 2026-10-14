using System;
using System.Collections.Generic;

class ListOfAdjacencies
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

        List<List<(int Neighbor, int Weight)>> graph =
            new List<List<(int Neighbor, int Weight)>>();

        for (int i = 0; i < 6; i++)
        {
            graph.Add(new List<(int Neighbor, int Weight)>());
        }

        graph[0].Add((1, 5));
        graph[0].Add((2, 12));
        graph[1].Add((2, 4));
        graph[1].Add((3, 8));
        graph[2].Add((3, 3));
        graph[2].Add((4, 7));
        graph[3].Add((4, 4));
        graph[3].Add((5, 15));
        graph[4].Add((5, 6));
        graph[4].Add((0, 10));

        Console.WriteLine("\nСписок смежностей:");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(stops[i] + ":");

            foreach (var neighbor in graph[i])
            {
                Console.WriteLine(
                    "  -> " + stops[neighbor.Neighbor] +
                    ", время: " + neighbor.Weight + " мин.");
            }
        }
    }
}