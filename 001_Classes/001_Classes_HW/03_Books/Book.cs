using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Book
    {
        public Author Author { get; set; }
        public Title Title { get; set; }
        public Content Content { get; set; }

        public Book() 
        {
            Author = new Author();
            Title = new Title();
            Content = new Content();
        }

        public Book(string author, string title, string content) : this()
        {
            Author.Value = author;
            Title.Value = title;
            Content.Value = content;
        }

        public void Show()
        {
            Author.Show();
            Title.Show();
            Content.Show();
        }
    }
}
