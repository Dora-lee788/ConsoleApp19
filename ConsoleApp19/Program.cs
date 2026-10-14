using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nТранспортная сеть города");
            Console.WriteLine("1. Список рёбер");
            Console.WriteLine("2. Список смежностей");
            Console.WriteLine("3. Матрица смежностей");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListOfEdges.Show();
                    break;

                case "2":
                    ListOfAdjacencies.Show();
                    break;

                case "3":
                    AdjacencyMatrix.Show();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Неверный пункт меню.");
                    break;
            }
        }
    }
}
