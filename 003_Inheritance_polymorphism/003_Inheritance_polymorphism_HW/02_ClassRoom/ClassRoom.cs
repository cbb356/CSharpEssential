namespace Inheritance_polymorphism
{
    internal class ClassRoom
    {
        private Pupil[] pupils;
        private const int NumberOfPupils = 4;

        public ClassRoom(params Pupil[] pupils) 
        {
            this.pupils = new Pupil[NumberOfPupils];

            if (pupils == null || pupils.Length == 0)
            {
                Console.WriteLine($"No pupil was submitted. {NumberOfPupils} default pupils were added to the class.");
                for (int i = 0; i < NumberOfPupils; i++)
                {
                    this.pupils[i] = new Pupil("Default");
                }
            }
            else if (pupils.Length > NumberOfPupils)
            {
                Console.WriteLine($"{pupils.Length} pupils were submitted. Only the first {NumberOfPupils} pupils were added to the class.");
                for (int i = 0; i < NumberOfPupils; i++)
                {
                    this.pupils[i] = pupils[i];
                }
            }
            else if (pupils.Length < NumberOfPupils)
            {
                Console.WriteLine($"Only {pupils.Length} pupil(s) was/were submitted. {(NumberOfPupils - pupils.Length)} default pupil(s) was/were added to the class.");
                for (int i = 0; i < pupils.Length; i++)
                {
                    this.pupils[i] = pupils[i];
                }
                for (int i = pupils.Length; i < NumberOfPupils; i++)
                {
                    this.pupils[i] = new Pupil("Default");
                }
            }
            else
            {
                Console.WriteLine($"{NumberOfPupils} pupils were submitted. All pupils were added to the class.");
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
