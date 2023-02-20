using System;

namespace HeartRate
{

    internal class HeartRate
    {
        //Problem‐01: Target‐Heart‐Rate Calculator

        //Health Rtate class atributes    
        private string firstName, lastName;
        private int birthYear, currentYear;

        //Class's Constructor (parameterized)
        public HeartRate(string firstName, string lastName, int birthYear, int currentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            CurrentYear = currentYear;
        }

        //CREATING PROPERTIES FOR EACH ATTRIBUTE SO WE CAN GET AND SET THE ATTRIBUTES
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = value;
            }
        }

        public int CurrentYear
        {
            get
            {
                return currentYear;
            }
            set
            {
                currentYear = value;
            }
        }

        //property that calculates and returns the person’s age (in years)
        public int CalulateAge
        {
            get
            {
                return CurrentYear - BirthYear;
            }
        }
        //property that calculates and returns the person’s maximum heart rate
        public int CalculateMaxHR
        {
            get
            {
                return 220 - CalulateAge;
            }
        }
        //propertie that calculate and return the person’s maximum target heart rate. 
        public int MinHR
        {
            get
            {
                return (int)(CalculateMaxHR * 0.5);

            }
        }
        //propertie that calculate and return the person’s minimum target heart rate. 
        public int MaxHR
        {
            get
            {
                return (int)(CalculateMaxHR * 0.85);

            }
        }
        //public method DisplayHealthRecord, that display patient’s data in tabular form
        public void DisplayPatientRecord()
        {
            Borders();

            Console.WriteLine($"{"|",-26} {"PATIENT HEART RATE RECORD"}  {"|",28}");

            Borders();

            Console.WriteLine($"| {"Patient Name",-32} | {lastName + ", " + firstName,-43} |");

            Borders();

            Console.WriteLine($"| {"Patient Birth Year",-32} | {birthYear,43} |");

            Borders();

            Console.WriteLine($"| {"Patient Age",-32} | {CalulateAge,43} |");

            Borders();

            Console.WriteLine($"| {"Maximum Heart Rate",-32} | {CalculateMaxHR,43} |");

            Borders();

            Console.WriteLine($"| {"Targe Heart Rate Range",-32} | {MinHR + "-" + MaxHR,43} |");

            Borders();
        }

        //a methode for creating the table's borders
        public void Borders()
        {
            Console.Write("|");
            for (int i = 0; i < 80; i++)
                Console.Write("-");
            Console.WriteLine("|");
        }

    }
}
