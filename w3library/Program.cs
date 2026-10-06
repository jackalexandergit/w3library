using w3library;

Book book = new Book();

// this information is for one book in our library

book.Title = "C# for beginners";
book.Author = "BillGates";
book.ISBN = "12345678";

book.DisplayInfo();

// this is another book in our library

Book book1 = new Book();
book1.Title = "C# Methods & Classes";
book1.Author = "Microsoft";
book1.ISBN = "55667778";

book1.DisplayInfo();