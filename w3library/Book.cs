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
        public String ISBN;

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
