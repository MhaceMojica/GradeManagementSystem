using System;
using CalculateGradeBL;
using StudentCredential;

namespace GradeSystemUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Management System!!!");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter your Course and Section: ");
            string courseSection = Console.ReadLine();
            Console.WriteLine("Enter Subject Grades");
            Console.Write("Data Structure: ");
            double datastruc = Convert.ToDouble(Console.ReadLine());
            Console.Write("Algorithms: ");
            double algo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Database Management: ");
            double database = Convert.ToDouble(Console.ReadLine());
            Console.Write("Programming3: ");
            double prog = Convert.ToDouble(Console.ReadLine());
            Console.Write("Data and Networking: ");
            double network = Convert.ToDouble(Console.ReadLine());

            double average = CalculateGradeBL.GradeManagement.CalculateGWA(datastruc, algo, database, prog, network);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("This is your Credentials");
            StudentCredentials studentinfo = new StudentCredentials(studentName, courseSection, average);
            studentinfo.DisplayCredentials();
            Console.WriteLine("----------------------------------------");


        }
    }
}