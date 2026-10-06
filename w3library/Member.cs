namespace w3library
{
    public class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

        // public properties
        public int MemberId
        {
            get { return memberId; }
            private set
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater than zero.");
                }
            }
        }
        public string Name
        {
            get { return name; }  // get method
            set
            { 
                if (!value.Any(char.IsDigit) && value != "") // ensure name does not contain any numbers
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers.");
                }
            }
        }
        public string Address
        {
            get { return address; }  // get method
            set { address = value; } // set method
        }
        public int Phone
        {
            get { return phone; }  // get method
            set { phone = value; } // set method
        }

        // member constructor
        public Member(int memberId, string name, string address, int phone)
        {
            this.MemberId = memberId; // Assigns the camelCase parameter to the PascalCase property
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        // output method
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone number: {Phone}");
            Console.WriteLine();
        }
    }
}
