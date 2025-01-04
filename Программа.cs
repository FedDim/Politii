using Политiи.Данныя;

namespace Политiи
{
    public class Программа
    {
        static void Main(string[] args)
        {
            Random random = new();

            int число = random.Next(75, 101);

            Дата.карта = new(число, random.Next(число - число / 10, число + число / 10 + 1));
            Дата.карта.Мѣстность = Генерація.ГенераціяКарты.ГенераціяМѣстности();

            for (int y = 0; y < Дата.карта.Высота; y++)
            {
                for (int x = 0; x < Дата.карта.Ширина; x++)
                {
                    Console.Write(Дата.карта.Мѣстность[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
