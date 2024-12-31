namespace Политiи.Данныя
{
    public class Политія(int номеръ, string имя, string цвѣтъ)
    {
        public int Номеръ { get; set; } = номеръ;
        public int ОД { get; set; }
        public int ЦЗ { get; set; }
        public string? Имя { get; set; } = имя;
        public string? Цвѣтъ { get; set; } = цвѣтъ;
    }
}
