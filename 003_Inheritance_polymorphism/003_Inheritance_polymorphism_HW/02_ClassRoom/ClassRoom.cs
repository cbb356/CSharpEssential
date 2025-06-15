namespace Inheritance_polymorphism
{
    internal class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils) 
        {
            if (pupils == null || pupils.Length < 2 || pupils.Length > 4)
                throw new ArgumentException("The number of pupils is incorrect");
            else
            {
                this.pupils = pupils;
            }
        }

        public void ShowPupilsInfo()
        {
            Console.WriteLine($"The class includes {pupils.Length} students");
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"\nThe information about {pupils[i].Name}:");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
            Console.WriteLine();
        }
    }
}
