using System;



namespace Lab4_02
{
    public interface ICatalog
    {
        public void print();
    }

    class Catalog : ICatalog

    {

        string[] Mark = { " bmw x5", " chevrolet cam ", " nissan gtr ", " toyota camry ", " honda civic ", " nissan x", " mustang sh ", "opel Ins", " mercedes w124", "volkswagen Golf" };

        string[] Colour = { "       Чорний", "Сiрий", "Фiолет", "Зелений", "Рожевий", "Срiбл", "Бiлий", "Чорний", "Оранж", "Зелений" };

        string[] Number = { "BC21KB", "BC7777AM", "AA1854HP", "BC1579KL", "AA0247LK", "AO1785KJ", "AA2245GG", "AH2452JA", "AA6754BN", "BC7845RT" };

        string[] Year = { "  1999", "2010", "2015", "2018", "2000", "2010", "2014", "2013", "2017", "1998" };

        string[] OwnerData = { "Мисик В.О. 1999р.н.", "Сачко Н.В. 2000р.н.", "Коломiєць С.Н. 1996р.н.", "Калин А.В. 2002р.н.", "Рибак Ю.В. 2002р.н.", "Квасниця Я.Р. 1996р.н.", "Туранський М.Д. 1999р.н.", "Iванов О.Г. 2002р.н.", "Моздзерович В.М. 1999р.н.", "Хамуляк Д.М. 2002р.н." };

        public Catalog()

        {
        }

        public void print()

        {
            Console.WriteLine("Марка, модель: \tКолiр: \tНомер: \t Piк: \tIнформацiя про власника: ");

            for (int i = 0; i < 10; i++)

            {

                Console.WriteLine("" + Mark[i] + "\t" + Colour[i] + "\t" + Number[i] + " " + Year[i] + "\t" + OwnerData[i]);

            }

        }

        public static void Main()

        {

            Catalog s1 = new Catalog();

            s1.print();

        }

    }

}