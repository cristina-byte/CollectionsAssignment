using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        private static Book[] topBooks = new Book[10];

        public static Book GetBook(int index)
        {
            if (topBooks[index] == null)
                throw new NullItemException($"\nNull item at index {index}");
            return topBooks[index];
        }

        public static void SetBook(int index, Book book)
        {
            topBooks[index] = book;
        }

        public static void ChangeOrder(int index1, int index2)
        {
            Book aux = GetBook(index1);
            topBooks[index1]=topBooks[index2];
            topBooks[index2]=aux;
        }

        public static Book GetBookByTitle(string title)
        {
           for(int i = 0; i < 10; i++)
            {
                if (topBooks[i]!=null)
                {
                    if (topBooks[i].Title == title)
                        return topBooks[i];
                }
            }
            return null;
        }

        public static int GetIndex(Book book)
        {
            if (book == null)
                throw new ArgumentNullException("The given argument is null");

            for (int i = 0; i < 10; i++)
                if (topBooks[i] != null && topBooks[i].Equals(book))
                    return i;

            return -1;
        }


        public static void ChangeOrder(string title1, string title2)
        {
            Book aux = GetBookByTitle(title1);
            Book book2 = GetBookByTitle(title2);
            try
            {
                int index1 = GetIndex(aux);
                int index2 = GetIndex(book2);

                topBooks[index1] = topBooks[index2];
                topBooks[index2] = aux;
            }

            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public static void Main(string[] args)
        {
            //set operations
            SetBook(0, new Book("The Handmaid's tale", "The book tells the story about a handmaid", "Margaret Atwood"));
            SetBook(1, new Book("1984", "The book is about manipulation", "George Orwell"));
            SetBook(7, new Book("Animals' Ferm", "The book tells the story of a ferm where animals got the controll over the ferm", "George Orwell"));

            //get operations
            try
            {
                Console.WriteLine(GetBook(0).ToString());
                Console.WriteLine(GetBook(1).ToString());
                Console.WriteLine(GetBook(7).ToString());
                Console.WriteLine(GetBook(9).ToString());
            }

            catch(NullItemException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //swap items by index
            ChangeOrder(0, 7);

            //print books after swapping
            Console.WriteLine("\nTop 10 books after swapping by index:");
            Console.WriteLine(GetBook(0).ToString());
            Console.WriteLine(GetBook(1).ToString());
            Console.WriteLine(GetBook(7).ToString());

            //swap items by titles
            ChangeOrder("1984", "The Handmaid's tale");

            //print books after swapping
            Console.WriteLine("\nTop 10 books after swapping by title:");
            Console.WriteLine(GetBook(0).ToString());
            Console.WriteLine(GetBook(1).ToString());
            Console.WriteLine(GetBook(7).ToString());
        }
    }
}
