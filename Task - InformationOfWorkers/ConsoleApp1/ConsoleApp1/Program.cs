using System.ComponentModel.DataAnnotations;
using System.Numerics;
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
            string[] jobs = new string[]{ "HR", "Audit", "Engineer"};
            int arrayLength = jobs.Length;

            bool resultUpperCaseLetters = false;
            bool resultLowerLetters = false;
            bool resultNumbers = false;

            Console.Write("Count of employees : ");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {                 
                Name(upperCaseLetters, lowerLetters, numbers, resultUpperCaseLetters, resultLowerLetters, resultNumbers);                              
                Surname(upperCaseLetters, lowerLetters, numbers, resultUpperCaseLetters, resultLowerLetters, resultNumbers);
                FatherName(upperCaseLetters, lowerLetters, numbers, resultUpperCaseLetters, resultLowerLetters, resultNumbers);
                Age(numbers);
                FinCode(upperCaseLetters, lowerLetters, numbers);
                PhoneNumber(upperCaseLetters, lowerLetters, numbers);
                JobPosition(upperCaseLetters, lowerLetters, jobs, arrayLength);             
                Salary(numbers);
            }
            Console.ReadLine();
        }
        public static void Name       (char[] upperCaseLetters, char[] lowerLetters, char[] numbers, bool resultUpperCaseLetters, bool resultLowerLetters, bool resultNumbers)
        {
            int son = 0;
            while (son == 0)
            {
                       Console.Write("Add worker's name: ");
                       string name = Console.ReadLine();
                   
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
                               Console.WriteLine("Name not accepted!" + " " + "Please try again");
                               Console.WriteLine("The name must contain only letters");
                               Console.WriteLine("");
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
                        son++;
                       }
                       else
                       {
                           Console.WriteLine("");
                           Console.WriteLine("Name not accepted!" + " " + "Please try again");
                           Console.WriteLine("The first letter should be uppercase and the following letters should be lowercase");
                           Console.WriteLine();
                       }
                  }
                  else
                  {
                      Console.WriteLine("");
                      Console.WriteLine("Name not accepted!" + " " + "Please try again");
                      Console.WriteLine("Letters must be longer than 2 and less than 20");
                      Console.WriteLine("");
                }
            }
                   
        }
        public static void Surname    (char[] upperCaseLetters, char[] lowerLetters, char[] numbers, bool resultUpperCaseLetters, bool resultLowerLetters, bool resultNumbers)
        {
           int son = 0;
           while (son == 0)
           {
                Console.Write("Add worker's surname: ");
                string surname = Console.ReadLine();
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
                        Console.WriteLine("Surname not accepted!" + " " + "Please try again");
                        Console.WriteLine("The Surname must contain only letters");
                        Console.WriteLine("");
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
                        son++;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Surname not accepted!" + " " + "Please try again");
                    Console.WriteLine("The first letter should be uppercase and the following letters should be lowercase");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Surname not accepted!" + " " + "Please try again");
                Console.WriteLine("Letters must be longer than 2 and less than 35");
                Console.WriteLine("");
            }
           }
        }
        public static void FatherName (char[] upperCaseLetters, char[] lowerLetters, char[] numbers, bool resultUpperCaseLetters, bool resultLowerLetters, bool resultNumbers)
        {
           int son = 0;
           while (son == 0)
           {
                Console.Write("Add worker's father's name: ");
             string fatherName = Console.ReadLine();
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
                        Console.WriteLine("Father name not accepted!" + " " + "Please try again");
                        Console.WriteLine("The name must contain only letters");
                        Console.WriteLine("");
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
                        son++;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Father name not accepted!" + " " + "Please try again");
                    Console.WriteLine("The first letter should be uppercase and the following letters should be lowercase");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Father name not accepted!" + " " + "Please try again");
                Console.WriteLine("Letters must be longer than 2 and less than 20");
                Console.WriteLine("");
            }
           }
        }
        public static void Age        (char[] numbers)
        {
           int son = 0;
           while (son == 0)
           {
                Console.Write("Add worker's age: ");
               string age = Console.ReadLine();
            try
            {
                 int convertAge = Convert.ToInt32(age);
                 if(convertAge >= 18 && convertAge <= 65)
                 {    
                     Console.WriteLine("");
                     Console.WriteLine("Age added successfully");
                     Console.WriteLine("");
                        son++;
                 }
                 else
                 {
                     Console.WriteLine("");
                     Console.WriteLine("Age not accepted!" + " " + "Please try again");
                     Console.WriteLine("Age should be between 18-65 years");
                     Console.WriteLine("");
                 }
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Age not accepted!" + " " + "Please try again");
                Console.WriteLine("Age must contain only numbers");
                Console.WriteLine("");
            }
           }
        }
        public static void FinCode    (char[] upperCaseLetters, char[] lowerLetters, char[] numbers)
        {
           int son = 0;
           while (son == 0)
           {
                Console.Write("Add worker's FIN code: ");
                string finCode = Console.ReadLine();
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
                        son++;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("FIN code not accepted!" + " " + "Please try again");
                    Console.WriteLine("*****FIN code must contain uppercase letters and numbers*****");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("FIN code not accepted!" + " " + "Please try again");
                Console.WriteLine("FIN code must be 7 numbers");
                Console.WriteLine("");
            }
           }
        }
        public static void PhoneNumber(char[] upperCaseLetters, char[] lowerLetters, char[] numbers)
        {
           int son = 0;
           while (son == 0)
           {
                Console.Write("Add worker's phone number: ");
                string phoneNumber = Console.ReadLine();
            string startChar = "+994";
            int i = 0;
            bool succes= false;

            if (phoneNumber.Length == 13)
            {
                int result = 0;
                for (i = 0; i < startChar.Length; i++)
                {
                    if (phoneNumber[i] != startChar[i] && i < startChar.Length)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Phone number not accepted!" + " " + "Please try again");
                        Console.WriteLine("Phone number must start with +994");
                        Console.WriteLine("");
                        succes = true;
                        break;
                    }
                    result++;
                }
                int sum = i;
                
                for ( ; sum < phoneNumber.Length; sum++)
                {                   
                    for(int j = 0; j < numbers.Length; j++)
                    {
                        if (phoneNumber[sum] == numbers[j])
                        {
                            result++;
                        }
                    }
                }
                if(result == phoneNumber.Length && succes != true)
                {
                   Console.WriteLine("");
                   Console.WriteLine("Phone number accepted");
                   Console.WriteLine("");
                        son++;
                }
                if (result != phoneNumber.Length && succes != true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Phone number not accepted!" + " " + "Please try again");
                    Console.WriteLine("phone number must consist of numbers");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Phone number not accepted!" + " " + "Please try again");
                Console.WriteLine("Phone number must contain 13 digits");
                Console.WriteLine("");
            }
           }
        }
        public static void JobPosition(char[] upperCaseLetters, char[] lowerLetters, string[] jobs, int arrayLength)
        {
           int son = 0;
           while (son == 0)
           {
                Console.WriteLine(" HR");
                Console.WriteLine(" Audit");
                Console.WriteLine(" Engineer");
                Console.Write("Add worker's job position: ");
                string jobPosition = Console.ReadLine();
            bool b = false;
            for (int i = 0; i < arrayLength; i++)
            {
                if(jobPosition == jobs[i])
                {
                    b = true;
                    break;
                }
            }
            if(b == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Worker profession accepted");
                Console.WriteLine("");
                    son++;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Worker profession not accepted!" + " " + "Please try again");
                Console.WriteLine("Please enter one of the jobs in the list");
                Console.WriteLine("");
            }
           }
        }
        public static void Salary(char[] numbers)
        {
           int son = 0;
            while (son == 0)
            {
                Console.Write("Add worker's salary: ");
                string salary = Console.ReadLine();
            try
            {
                int convertSalary = Convert.ToInt32(salary);
                if(convertSalary >= 1500 && convertSalary <= 5000)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Salary accepted");
                    Console.WriteLine("");
                        son++;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Salary not accepted!" + " " + "Please try again");
                    Console.WriteLine("The amount you enter should be between 1500 and 5000");
                    Console.WriteLine("");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Salary not accepted!" + " " + "Please try again");
                Console.WriteLine("Use numbers only");
                Console.WriteLine("");
            }
            }
        }
    }
}