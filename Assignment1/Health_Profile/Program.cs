using System;
using System.Xml.Linq;


namespace HeathProfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //USER INPUT INFO

            Console.Write("Enter your First Name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter your LastName: ");
            string lName = Console.ReadLine();
            Console.Write("Enter your Birth Year: ");
            int birthY = int.Parse(Console.ReadLine());
            Console.Write("Enter the current year:");
            int currentY = int.Parse(Console.ReadLine());
            Console.Write("Enter your Height(in INCHES): ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter your weight(in POUNDS): ");
            int weight = int.Parse(Console.ReadLine());


            //SENDING THE INPUTS TO THE CONSTRUCTOR 
            HealthProfile healthProfile = new HealthProfile(fName, lName, birthY, height, weight, currentY);
            healthProfile.DisplayPatientRecord();
        }
    }

}
