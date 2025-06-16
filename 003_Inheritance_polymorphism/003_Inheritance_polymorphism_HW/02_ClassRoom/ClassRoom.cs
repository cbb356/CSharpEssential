namespace Inheritance_polymorphism
{
    internal class ClassRoom
    {
        private Pupil[] pupils;
        private const int numberOfPupils = 4;

        public ClassRoom(params Pupil[] pupils) 
        {
            this.pupils = new Pupil[numberOfPupils];

            if (pupils == null || pupils.Length == 0)
            {
                Console.WriteLine($"No pupil was submitted. {numberOfPupils} default pupils were added to the class.");
                for (int i = 0; i < numberOfPupils; i++)
                {
                    this.pupils[i] = new Pupil("Default");
                }
            }
            else if (pupils.Length == numberOfPupils)
            {
                Console.WriteLine($"{numberOfPupils} pupils were submitted. All pupils were added to the class.");
                this.pupils = pupils;
            }
            else if (pupils.Length > numberOfPupils)
            {
                Console.WriteLine($"{pupils.Length} pupils were submitted. Only the first {numberOfPupils} pupils were added to the class.");
                for (int i = 0; i < numberOfPupils; i++)
                {
                    this.pupils[i] = pupils[i];
                }
            }
            else if (pupils.Length < numberOfPupils)
            {
                Console.WriteLine($"Only {pupils.Length} pupil(s) was/were submitted. {(numberOfPupils - pupils.Length)} default pupil(s) was/were added to the class.");
                for (int i = 0; i < pupils.Length; i++)
                {
                    this.pupils[i] = pupils[i];
                }
                for (int i = pupils.Length; i < numberOfPupils; i++)
                {
                    this.pupils[i] = new Pupil("Default");
                }
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
