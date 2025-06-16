namespace Inheritance_polymorphism
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("The document was opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("You can edit the document in the Pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("You can save the document in the Pro version");
        }
    }

    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("The document was edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("You can save the document in the new format in the Expert version");
        }
    }

    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("The document was saved in the new format");
        }
    }
}
