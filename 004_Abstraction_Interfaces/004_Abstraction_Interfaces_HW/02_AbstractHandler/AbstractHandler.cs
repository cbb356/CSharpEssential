namespace AbstractHandler
{
    internal abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();    
    }
    
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML document opened");
        }

        public override void Create()
        {
            Console.WriteLine("XML document created");
        }

        public override void Change()
        {
            Console.WriteLine("XML document changed");
        }

        public override void Save()
        {
            Console.WriteLine("XML document saved");
        }
    }

    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT document opened");
        }

        public override void Create()
        {
            Console.WriteLine("TXT document created");
        }

        public override void Change()
        {
            Console.WriteLine("TXT document changed");
        }

        public override void Save()
        {
            Console.WriteLine("TXT document saved");
        }
    }

    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC document opened");
        }

        public override void Create()
        {
            Console.WriteLine("DOC document created");
        }

        public override void Change()
        {
            Console.WriteLine("DOC document changed");
        }

        public override void Save()
        {
            Console.WriteLine("DOC document saved");
        }
    }
}
