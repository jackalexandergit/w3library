using w3library;

public class Program
{
    static void Main(string[] args)
    {

        // this information is for books in our library
        Book book = new Book("C# for beginners", "BillGates", 12345678);
        Book book1 = new Book("C# Methods & Classes", "Microsoft", 55667778);

        Console.WriteLine("Current available books\n");
        book.DisplayInfo();
        book1.DisplayInfo();

        // this information is for members in our library
        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);

        // testing the validation logic with invalid data
        // Member invalidMember = new Member(-5, "Rob0t C0p", "50 Main Street", 0781122334);

        Console.WriteLine("Current library members\n");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}



