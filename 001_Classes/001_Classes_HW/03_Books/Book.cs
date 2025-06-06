using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Book
    {
        private Author _author;
        private Title _title;
        private Content _content;
        
        public string Author 
        { 
            set 
            { 
                _author.Value = value;
            } 
        }

        public string Title
        {
            set
            {
                _title.Value = value;
            }
        }

        public string Content
        {
            set
            {
                _content.Value = value;
            }
        }

        public Book() 
        {
            _author = new Author();
            _title = new Title();
            _content = new Content();
        }

        public Book(string author, string title, string content) : this()
        {
            _author.Value = author;
            _title.Value = title;
            _content.Value = content;
        }

        public void Show()
        {
            _author.Show();
            _title.Show();
            _content.Show();
        }
    }
}
