namespace Document
{
    internal class Document
    {
        // Поля
        private Title title;
        private Body body;
        private Footer footer;

        public Document(Title title, Body body, Footer footer)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }

    }
}
