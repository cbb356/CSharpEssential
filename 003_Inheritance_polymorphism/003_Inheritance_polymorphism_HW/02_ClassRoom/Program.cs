namespace Inheritance_polymorphism
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Pupil excelentPupil1 = new ExcelentPupil("John Doe");
            Pupil excelentPupil2 = new ExcelentPupil("Mary Stewart");
            Pupil goodPupil1 = new GoodPupil("William Smith");
            Pupil goodPupil2 = new GoodPupil("Jane little");
            Pupil badPupil = new BadPupil("Jack Reaper");

            ClassRoom classRoom1 = new ClassRoom(excelentPupil1, goodPupil1, goodPupil2, badPupil);
            classRoom1.ShowPupilsInfo();

            ClassRoom classRoom2 = new ClassRoom(excelentPupil1, goodPupil1, badPupil);
            classRoom2.ShowPupilsInfo();

            ClassRoom classRoom3 = new ClassRoom(excelentPupil1, badPupil);
            classRoom3.ShowPupilsInfo();

            ClassRoom classRoom4 = new ClassRoom();
            classRoom4.ShowPupilsInfo();

            ClassRoom classRoom5 = new ClassRoom(null);
            classRoom5.ShowPupilsInfo();

            ClassRoom classRoom6 = new ClassRoom(excelentPupil1, excelentPupil2, goodPupil1, goodPupil2, badPupil);
            classRoom6.ShowPupilsInfo();

            //Delay
            Console.ReadKey();
        }
    }
}
