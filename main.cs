// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math
using System;

class Program
{
    public static void Main(string[] args)
    {
        var days = Console.ReadLine();
        int age;

        //Input 
        Console.WriteLine("This program checks eligibility for student pricing.");
        Console.WriteLine("");
        Console.Write("Enter day of the week: ");
        days = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());
 
        //Process
        if ((days == "Tuesday" || days == "Thursday") || (age > 12 && age < 21))
        {
            Console.WriteLine("You are eligible for student pricing");
        } else {
            Console.WriteLine("You must pay regular price");
        }
        
        Console.WriteLine("\nDone."); 
    }
}