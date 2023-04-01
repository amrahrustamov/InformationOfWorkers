namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Name();
                Surname();
                FatherName();
                Age();
                PhoneNumber();
                JobPosition();
                Salary();
            }
        }
        static void Name()
        {
              Console.WriteLine("Add worker's name: ");

        }
        static void Surname()
        {
            Console.WriteLine("Add worker's surname: ");
        }
        static void FatherName()
        {
            Console.WriteLine("Add worker's father's name: ");
        }
        static void Age()
        {
            Console.WriteLine("Add worker's age: ");
        }
        static void PhoneNumber()
        {
            Console.WriteLine("Add worker's phone number: ");

        }
        static void JobPosition()
        {
            Console.WriteLine("Add worker's job position: ");
        }
        static void Salary()
        {
            Console.WriteLine("Add worker's salary: ");
        }
    }
}