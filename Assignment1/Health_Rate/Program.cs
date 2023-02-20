using System;


namespace HeartRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User input 

            Console.Write("Enter your First Name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter your LastName: ");
            string lName = Console.ReadLine();
            Console.Write("Enter your Birth Year: ");
            int birthY = int.Parse(Console.ReadLine());
            Console.Write("Enter your Current Year: ");
            int currentY = int.Parse(Console.ReadLine());

            //SENDING THE INPUTS TO THE CONSTRUCTOR 
            HeartRate hr = new HeartRate(fName, lName, birthY, currentY);
            hr.DisplayPatientRecord();
        }
    }
}