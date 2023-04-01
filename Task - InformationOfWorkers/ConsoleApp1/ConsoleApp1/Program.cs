using System.Xml.Linq;

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
            bool resultNumbers = false;
            string name;
            string surname;
            string fatherName;
            string age;
            string finCode;
            byte phoneNumber;            
            string jobPosition;
            double salary;          

            Console.Write("Count of employees : ");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.Write("Add worker's name: ");
                name = Console.ReadLine();
                Name(upperCaseLetters, lowerLetters, numbers, resultUpperCaseLetters, resultLowerLetters, resultNumbers, name);

                Console.Write("Add worker's surname: ");
                surname = Console.ReadLine();
                Surname(upperCaseLetters, lowerLetters, numbers, resultUpperCaseLetters, resultLowerLetters, resultNumbers, surname);

                Console.Write("Add worker's father's name: ");
                fatherName = Console.ReadLine();
                FatherName(upperCaseLetters, lowerLetters, numbers, resultUpperCaseLetters, resultLowerLetters, resultNumbers, fatherName);

                Console.Write("Add worker's age: ");
                age = Console.ReadLine();
                Age(numbers, age);

                Console.Write("Add worker's FIN code: ");
                finCode = Console.ReadLine();
                FinCode(upperCaseLetters, lowerLetters, numbers, finCode);

                PhoneNumber();
                JobPosition();
                Salary();
            }
        }
        public static void Name       (char[] upperCaseLetters, char[] lowerLetters, char[] numbers, bool resultUpperCaseLetters, bool resultLowerLetters, bool resultNumbers, string name)
        {
            int sum = 1;
           if (name.Length < 20 && name.Length > 2)
           {
                for (int j = 0; j < name.Length; j++)
                {
                    for (int k = 0; k < name.Length; k++)
                    {
                        for (int g = 0; g < numbers.Length; g++)
                        {
                            if (name[k] == numbers[g])
                            {
                                resultNumbers = true;
                                break;
                            }
                        }
                    }
                    if (resultNumbers == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Name not accepted!");
                        Console.WriteLine("The name must contain only letters");
                        Console.ReadLine();
                        break;
                    }
                    if (j == 0)
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
                    if (j < name.Length)
                    {
                        for (int a = 0; a < lowerLetters.Length; a++)
                        {
                            if (name[j] == lowerLetters[a])
                            {
                                sum = sum + 1;
                                if (sum == name.Length)
                                    resultLowerLetters = true;
                            }
                        }
                    }
                }
                if (resultLowerLetters == true && resultUpperCaseLetters == true)
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
                    Console.ReadLine();
                }
           }
           else
           {
               Console.WriteLine("");
               Console.WriteLine("The name is not entered correctly!");
               Console.WriteLine("Letters must be greater than 2 and less than 20");
               Console.ReadLine();
           }
        }
        public static void Surname    (char[] upperCaseLetters, char[] lowerLetters, char[] numbers, bool resultUpperCaseLetters, bool resultLowerLetters, bool resultNumbers, string surname)
        {
            int sum = 1;
            if (surname.Length < 35 && surname.Length > 2)
            {
                for (int j = 0; j < surname.Length; j++)
                {
                    for (int k = 0; k < surname.Length; k++)
                    {
                        for (int g = 0; g < numbers.Length; g++)
                        {
                            if (surname[k] == numbers[g])
                            {
                                resultNumbers = true;
                                break;
                            }
                        }
                    }
                    if (resultNumbers == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Surname not accepted!");
                        Console.WriteLine("The Surname must contain only letters");
                        Console.ReadLine();
                        break;
                    }
                    if (j == 0)
                    {
                        for (int a = 0; a < upperCaseLetters.Length; a++)
                        {
                            if (surname[j] == upperCaseLetters[a])
                            {
                                resultUpperCaseLetters = true;
                                j++;
                                break;
                            }
                        }
                    }
                    if (j < surname.Length)
                    {
                        for (int a = 0; a < lowerLetters.Length; a++)
                        {
                            if (surname[j] == lowerLetters[a])
                            {
                                sum = sum + 1;
                                if (sum == surname.Length)
                                    resultLowerLetters = true;
                            }
                        }
                    }
                }
                if (resultLowerLetters == true && resultUpperCaseLetters == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Surname added successfully");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("The surname is not entered correctly!");
                    Console.WriteLine("The first letter should be uppercase and the following letters should be lowercase");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("The surname is not entered correctly!");
                Console.WriteLine("Letters must be greater than 2 and less than 35");
                Console.ReadLine();
            }
        }
        public static void FatherName (char[] upperCaseLetters, char[] lowerLetters, char[] numbers, bool resultUpperCaseLetters, bool resultLowerLetters, bool resultNumbers, string fatherName)
        {
            int sum = 1;
            if (fatherName.Length < 20 && fatherName.Length > 2)
            {
                for (int j = 0; j < fatherName.Length; j++)
                {
                    for (int k = 0; k < fatherName.Length; k++)
                    {
                        for (int g = 0; g < numbers.Length; g++)
                        {
                            if (fatherName[k] == numbers[g])
                            {
                                resultNumbers = true;
                                break;
                            }
                        }
                    }
                    if (resultNumbers == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Name not accepted!");
                        Console.WriteLine("The name must contain only letters");
                        Console.ReadLine();
                        break;
                    }
                    if (j == 0)
                    {
                        for (int a = 0; a < upperCaseLetters.Length; a++)
                        {
                            if (fatherName[j] == upperCaseLetters[a])
                            {
                                resultUpperCaseLetters = true;
                                j++;
                                break;
                            }
                        }
                    }
                    if (j < fatherName.Length)
                    {
                        for (int a = 0; a < lowerLetters.Length; a++)
                        {
                            if (fatherName[j] == lowerLetters[a])
                            {
                                sum = sum + 1;
                                if (sum == fatherName.Length)
                                    resultLowerLetters = true;
                            }
                        }
                    }
                }
                if (resultLowerLetters == true && resultUpperCaseLetters == true)
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
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("The name is not entered correctly!");
                Console.WriteLine("Letters must be greater than 2 and less than 20");
                Console.ReadLine();
            }
        }
        public static void Age        (char[] numbers, string age)
        {            
            try
            {
                 int convertAge = Convert.ToInt32(age);
                 if(convertAge >= 18 && convertAge <= 65)
                 {    
                     Console.WriteLine("");
                     Console.WriteLine("Age added successfully");
                     Console.WriteLine("");                     
                 }
                 else
                 {
                     Console.WriteLine("");
                     Console.WriteLine("Age not accepted!");
                     Console.WriteLine("Age should be between 18-65 years");
                     Console.WriteLine("");
                 }
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Age not accepted!");
                Console.WriteLine("Age must contain only numbers");
                Console.WriteLine("");
            }
        }
        public static void FinCode    (char[] upperCaseLetters, char[] lowerLetters, char[] numbers, string finCode)
        {
            int upperCase = 0;
            int countNumbers = 0;
            int result = 0;
            if(finCode.Length == 7)
            {
                for(int i = 0; i < finCode.Length; i++)
                {
                    for(int j = 0; j < upperCaseLetters.Length; j++)
                    {
                        if (finCode[i] == upperCaseLetters[j])
                        {
                            upperCase++;
                        }
                    }
                    for(int a = 0; a < numbers.Length; a++)
                    {
                        if (finCode[i] == numbers[a])
                        {
                            countNumbers++;
                        }
                    }
                }
                result = upperCase + countNumbers;

                if(result == finCode.Length)
                {
                    Console.WriteLine("");
                    Console.WriteLine("FIN code accepted");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("FIN code not accepted!");
                    Console.WriteLine("FIN code must contain uppercase letters and numbers");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("FIN code not accepted!");
                Console.WriteLine("FIN code must be 7 numbers");
                Console.WriteLine("");
            }
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