//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


using System;

class AgeAfterYears
{
    static void Main()
    {
        Console.WriteLine("Please submit your age:");
        string a = Console.ReadLine();
        int age = Convert.ToInt32(a);
        int newAge = age + 10;
        Console.WriteLine("In ten years your age is going to be "+ newAge);
    }
}
