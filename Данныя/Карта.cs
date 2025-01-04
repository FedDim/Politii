namespace Политiи.Данныя
{
    public class Карта(int высота, int ширина)
    {
        public int Высота { get; set; } = высота;
        public int Ширина { get; set; } = ширина;
        public int[,]? Мѣстность { get; set; }
        public int[,]? НомераТерриторій { get; set; }
        public int[,]? НомераПолитій { get; set; }
    }
}
