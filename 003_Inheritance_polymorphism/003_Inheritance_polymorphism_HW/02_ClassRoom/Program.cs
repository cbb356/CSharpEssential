namespace Inheritance_polymorphism
{
    internal class Program
    {
        /* Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
         * Потрібно: Створити клас, який представляє навчальний клас ClassRoom. 
         * Створіть клас учень Pupil. У тілі класу створіть методи void Study(), void Read(), 
         * void Write(), void Relax(). Створіть 3 похідні класу ExcelentPupil, GoodPupil, BadPupil 
         * від класу базового класу Pupil і перевизначте кожен із методів, залежно від успішності учня. 
         * Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів. 
         * Передбачте можливість, що користувач може передати 2 або 3 аргументи. 
         * Виведіть інформацію про те, як усі учні екземпляра класу ClassRoom 
         * вміють вчитися, читати, писати, відпочивати. 
         */

        static void Main(string[] args)
        {
            Pupil excelentPupil1 = new ExcelentPupil()
            { 
                Name = "John Doe"
            };

            Pupil excelentPupil2 = new ExcelentPupil()
            {
                Name = "Mary Stewart"
            };

            Pupil goodPupil1 = new GoodPupil()
            {
                Name = "William Smith"
            };

            Pupil goodPupil2 = new GoodPupil()
            {
                Name = "Jane little"
            };

            Pupil badPupil = new BadPupil()
            {
                Name = "Jack Reaper"
            };

            ClassRoom classRoom1 = new ClassRoom(excelentPupil1, goodPupil1, goodPupil2, badPupil);
            classRoom1.ShowPupilsInfo();

            ClassRoom classRoom2 = new ClassRoom(excelentPupil1, goodPupil1, badPupil);
            classRoom2.ShowPupilsInfo();

            ClassRoom classRoom3 = new ClassRoom(excelentPupil1, badPupil);
            classRoom3.ShowPupilsInfo();

            ClassRoom classRoom4 = new ClassRoom();
            classRoom4.ShowPupilsInfo();
        }
    }
}
