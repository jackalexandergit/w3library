// Jack Alexander
// 06/10/2026

using System;
using System.Collections.Generic;
using System.Text;

namespace w3library
{
    public class Book
    {
        public String Title;
        public String Author;
        public int ISBN;

        // paramaterised constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
