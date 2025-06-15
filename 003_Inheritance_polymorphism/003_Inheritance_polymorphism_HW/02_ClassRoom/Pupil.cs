namespace Inheritance_polymorphism
{
    internal class Pupil
    {
        public string Name { get; set; }

        public virtual void Study()
        {
            Console.WriteLine("The pupil studies");
        }

        public virtual void Read()
        {
            Console.WriteLine("The pupil reads");
        }

        public virtual void Write()
        {
            Console.WriteLine("The pupil studies");
        }

        public virtual void Relax()
        {
            Console.WriteLine("The pupil relaxes");
        }
    }
}
