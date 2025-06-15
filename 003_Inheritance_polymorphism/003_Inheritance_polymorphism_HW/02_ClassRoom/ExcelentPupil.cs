namespace Inheritance_polymorphism
{
    internal class ExcelentPupil: Pupil
    {
        public override void Study()
        {
            Console.WriteLine("The pupil studies very well");
        }

        public override void Read()
        {
            Console.WriteLine("The pupil reads very well");
        }

        public override void Write()
        {
            Console.WriteLine("The pupil writes very well");
        }

        public override void Relax()
        {
            Console.WriteLine("The pupil rarely relaxes");
        }
    }
}
