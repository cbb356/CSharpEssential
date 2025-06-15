namespace Inheritance_polymorphism
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("The pupil does not study well");
        }

        public override void Read()
        {
            Console.WriteLine("The pupil does not read well");
        }

        public override void Write()
        {
            Console.WriteLine("The pupil does not write well");
        }

        public override void Relax()
        {
            Console.WriteLine("The pupil relaxes very well");
        }
    }
}
