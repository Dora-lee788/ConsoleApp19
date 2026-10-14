using System;

class AdjacencyMatrix
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

        const int INF = 1000000;
        int[,] graph = new int[6, 6];

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                graph[i, j] = INF;
            }

            graph[i, i] = 0;
        }

        graph[0, 1] = 5;
        graph[0, 2] = 12;
        graph[1, 2] = 4;
        graph[1, 3] = 8;
        graph[2, 3] = 3;
        graph[2, 4] = 7;
        graph[3, 4] = 4;
        graph[3, 5] = 15;
        graph[4, 5] = 6;
        graph[4, 0] = 10;

        Console.WriteLine("\nМатрица смежностей:");
        Console.Write("".PadRight(24));

        for (int i = 0; i < 6; i++)
        {
            Console.Write((i + 1).ToString().PadLeft(8));
        }

        Console.WriteLine();

        for (int i = 0; i < 6; i++)
        {
            Console.Write(stops[i].PadRight(24));

            for (int j = 0; j < 6; j++)
            {
                if (graph[i, j] == INF)
                {
                    Console.Write("-".PadLeft(8));
                }
                else
                {
                    Console.Write(
                        graph[i, j].ToString().PadLeft(8));
                }
            }

            Console.WriteLine();
        }
    }
}