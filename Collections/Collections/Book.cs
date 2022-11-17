using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Book(string title, string description,string author)
        {
            Title = title;
            Description = description;
            Author = author;
        }

        public override string ToString()
        {
            return $"Title:{Title}; \nDescription:{Description}; \nAuthor:{Author};\n";
        }
    }
}
