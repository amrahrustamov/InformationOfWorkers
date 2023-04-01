namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] upperCaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            bool resultUpperCaseLetters = false;
            bool resultLowerLetters = false;
            string name;
            string surname;
            string fatherName;
            byte age;
            string personalNo;
            byte phoneNumber;            
            string jobPosition;
            double salary;          

            Console.Write("The number of employees to be added to the system :");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.Write("Add worker's name: ");
                name = Console.ReadLine();
                Name(upperCaseLetters, lowerLetters, resultUpperCaseLetters, resultLowerLetters, name);
                Surname();
                FatherName();
                Age();
                PhoneNumber();
                JobPosition();
                Salary();
            }
        }
        public static void Name(char[] upperCaseLetters, char[] lowerLetters, bool resultUpperCaseLetters, bool resultLowerLetters, string name)
        {
            int sum = 1;

            if (name.Length < 20 && name.Length > 2)
            {
                for (int j = 0; j < name.Length; j++)
                {                 
                    if(j == 0)
                    {
                      for (int a = 0; a < upperCaseLetters.Length; a++)
                      {
                          if (name[j] == upperCaseLetters[a])
                          {
                                resultUpperCaseLetters = true;
                                j++;
                                break;
                          }
                      }
                    }
                    if(j < name.Length)
                    {
                        for(int a = 0; a < lowerLetters.Length; a++)
                        {
                            if (name[j] == lowerLetters[a])
                            {                                
                                sum = sum + 1;
                                if(sum == name.Length)
                                    resultLowerLetters = true;                              
                            }
                        }
                    }
                }
                if(resultLowerLetters == true && resultUpperCaseLetters == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Name added successfully");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("The name is not entered correctly!");
                    Console.WriteLine("The first letter should be uppercase and the following letters should be lowercase");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("The name is not entered correctly!");
                Console.WriteLine("Letters must be greater than 2 and less than 20");
                Console.WriteLine("");
            }
            
        }
        public static void Surname()
        {
            Console.Write("Add worker's surname: ");
        }
        public static void FatherName()
        {
            Console.Write("Add worker's father's name: ");
        }
        public static void Age()
        {
            Console.Write("Add worker's age: ");
        }
        public static void PhoneNumber()
        {
            Console.Write("Add worker's phone number: ");

        }
        public static void JobPosition()
        {
            Console.Write("Add worker's job position: ");
        }
        public static void Salary()
        {
            Console.Write("Add worker's salary: ");
        }
    }
}