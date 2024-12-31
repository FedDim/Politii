namespace Политiи.Генерація
{
    public static class ГенераціяКарты
    {
        public static string[,] Генерація()
        {
            string[,] карта = new string[25, 25];

            for (int y = 0; y < карта.GetLength(0); y++)
            {
                for (int x = 0; x < карта.GetLength(1); x++)
                {
                    карта[y, x] = $"{x + y}";
                    карта[y, x] = карта[y, x];
                    while (карта[y, x].Length != 3) карта[y, x] += "_";

                }
            }

            return карта;
        }
    }
}
