﻿namespace Политiи.Данныя
{
    public class База
    {
        public const int ЦЗ_ТЕРРИТОРІЯ = 2;
        public const int ЦЗ_ПОРТЪ = 5;
        public const int ЦЗ_КРѢПОСТЬ = 10;

        public const string ТЕРРИТОРІЯ_ЗЕМЛЯ = "#";
        public const string ТЕРРИТОРІЯ_МОРЕ = "~";
        public const string ТЕРРИТОРІЯ_ГОРА = "^";

        public static string[,] типыКартъ = new string[,]
        {
            { "Континенты", "Описаніе: ​Большіе​ массивы суши формируются въ центрѣ карты, съ границами, полностью покрытыми водой. Это даетъ игрокамъ ​стабильныя​ ​стартовыя​ позиціи и стратегическую важность центральныхъ территорій." +
                "\nНа выходѣ: Нѣсколько крупныхъ сушъ съ равномѣрными береговыми линіями, центръ карты доминируетъ суша, а края полностью покрыты океаномъ." },
            { "Архипелагъ", "Описаніе: Карта состоитъ изъ множества маленькихъ острововъ, равномѣрно распредѣленныхъ по всей картѣ. Взаимодѣйствіе между территоріями сосредоточено вокругъ связи черезъ воду." +
                "\nНа выходѣ: Большое количество мелкихъ острововъ, раздѣленныхъ океаномъ." },
            { "Острова", "Описаніе: Карта содержитъ нѣсколько крупныхъ острововъ, расположенныхъ ближе къ центру. Каждый островъ четко отдѣленъ водой, создавая ​уникальныя​ условія для ​покраса​ территорій." +
                "\nНа выходѣ: Нѣсколько крупныхъ острововъ съ четкими границами, окруженными водой." },
            { "Полуострова", "Описаніе: Нѣсколько сушъ выступаютъ въ океанъ въ видѣ полуострововъ съ длинными и извилистыми береговыми линіями. Этотъ типъ карты стимулируетъ взаимодѣйствіе ​политій​ вдоль береговъ." +
                "\nНа выходѣ: Нѣсколько крупныхъ полуострововъ, окруженныхъ водой, съ увеличенной плотностью береговыхъ территорій." },
        };
    }
}
