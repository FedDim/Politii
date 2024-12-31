using Политiи.Данныя;

namespace Политiи
{
    public class Программа
    {
        static void Main(string[] args)
        {
            for (int y = 0; y < Дата.карта.GetLength(0); y++)
            {
                for (int x = 0; x < Дата.карта.GetLength(1); x++)
                {
                    Console.Write(Дата.карта[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
