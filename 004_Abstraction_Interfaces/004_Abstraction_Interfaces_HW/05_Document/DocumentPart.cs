namespace Document
{
    internal abstract class DocumentPart
    {
        protected string content;

        public abstract string Content { protected get; set; }

        public abstract void Show();
    }
}
