namespace Inheritance_polymorphism
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("The pupil studies well");
        }

        public override void Read()
        {
            Console.WriteLine("The pupil reads well");
        }

        public override void Write()
        {
            Console.WriteLine("The pupil writes well");
        }

        public override void Relax()
        {
            Console.WriteLine("The pupil relaxes enough");
        }
    }
}
