// Jack Alexander
// 06/10/2026

using System;
using System.Collections.Generic;
using System.Text;

namespace w3library
{
    public class Book
    {
        // private fields

        private string title;
        private string author;
        private int isbn;

        // public properties

        public string Title
        {
            get { return title; }  // get method
            set
            {
                // Checks if any character in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Title cannot contain numbers.");
                }
            }
        }
        public string Author
        {
            get { return author; }  // get method
            set {
                // Checks if any character in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }

        public int ISBN
        {
            get { return isbn; }  // get method
            set {
                // Checks that the incoming int is not a string
                if (value >0)
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        // paramaterised constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        // methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
