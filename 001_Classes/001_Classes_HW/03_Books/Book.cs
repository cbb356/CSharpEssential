namespace Classes
{
    internal class Book
    {
        private Author author;
        private Title title;
        private Content content;
        
        public string Author 
        { 
            set 
            { 
                author.Value = value;
            } 
        }

        public string Title
        {
            set
            {
                title.Value = value;
            }
        }

        public string Content
        {
            set
            {
                content.Value = value;
            }
        }

        public Book() 
        {
            author = new Author();
            title = new Title();
            content = new Content();
        }

        public Book(string author, string title, string content) : this()
        {
            this.author.Value = author;
            this.title.Value = title;
            this.content.Value = content;
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
