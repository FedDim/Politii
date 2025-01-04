namespace Политiи.Генерація
{
    public class Шумъ
    {
        int[] перестановки = new int[512];
        Random random = new();

        public Шумъ()
        {
            for (int i = 0; i < 256; i++)
            {
                перестановки[i] = i;
            }

            Перестановка();

            Array.Copy(перестановки, 0, перестановки, 256, 256);
        }

        private void Перестановка()
        {
            for (int i = 255; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (перестановки[i], перестановки[j]) = (перестановки[j], перестановки[i]);
            }
        }

        private float Сглаживаніе(float f)
        {
            return f * f * f * (f * (f * 6 - 15) + 10);
        }

        private float ЛинейныяИнтерполяція(float a, float b, float f)
        {
            return a + f * (b - a);
        }

        private float Градіентъ(int хэшъ, float x, float y)
        {
            int h = хэшъ & 0xF;
            float u = h < 8 ? x : y;
            float v = h < 4 ? y : (h == 12 || h == 14) ? x : 0;

            return ((h & 1) != 0 ? -u : u) + ((h & 2) != 0 ? -v : v);
        }

        public float Шумъ2Д(float x, float y)
        {
            int X = (int)x & 255;
            int Y = (int)y & 255;

            x -= (float)Math.Floor(x);
            y -= (float)Math.Floor(y);

            float n0, n1, n2;
            float u = Сглаживаніе(x);
            float v = Сглаживаніе(y);

            int gi0 = перестановки[X + перестановки[Y]];
            int gi1 = перестановки[X + 1 + перестановки[Y]];
            int gi2 = перестановки[X + перестановки[Y + 1]];
            int gi3 = перестановки[X + 1 + перестановки[Y + 1]];

            n0 = Градіентъ(gi0, x, y);
            n1 = Градіентъ(gi1, x - 1, y);
            n2 = Градіентъ(gi2, x, y - 1);

            float nx0 = ЛинейныяИнтерполяція(n0, n1, u);
            float nx1 = ЛинейныяИнтерполяція(Градіентъ(gi3, x - 1, y - 1), n2, u);

            return ЛинейныяИнтерполяція(nx0, nx1, v);
        }

        public float МногократныйШумъ2Д(float x, float y,
        int октавы = 1,
        float устойчивостьОктавъ = 0.5f)
        {
            float всего = 0;
            float частота = 1;
            float амплитуда = 1;
            float максимумъ = 0;

            for (int i = 0; i < октавы; i++)
            {
                всего += Шумъ2Д(x * частота, y * частота) * амплитуда;
                максимумъ += амплитуда;
                амплитуда *= устойчивостьОктавъ;
                частота *= 2;
            }

            return всего / максимумъ;
        }
    }
}
