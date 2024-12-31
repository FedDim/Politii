namespace Политiи.Данныя
{
    public class Территорія(int номеръ, int типъ)
    {
        public int Номеръ { get; set; } = номеръ;
        public int Типъ { get; set; } = типъ;
        public int[]? ТерриторіиСоседи { get; set; }
    }
}
