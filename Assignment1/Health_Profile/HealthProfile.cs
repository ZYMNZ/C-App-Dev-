using System;
using System.Xml.Linq;

namespace HeathProfile
{
    //Problem‐02: Computerization of Health Records

    internal class HealthProfile
    {
        //Health Profile class atributes
        private string firstName, lastName;
        private int birthYear, currentYear, height, weight;

        //Class's Constructor (parameterized)
        public HealthProfile(string firstName, string lastName, int birthYear, int height, int weight, int currrentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            Height = height;
            Weight = weight;
            CurrentYear= currrentYear;
        }

        //CREATING PROPERTIES FOR EACH ATTRIBUTE SO WE CAN GET AND SET THE ATTRIBUTES
        public string FirstName
        {
            get //get method
            { 
                return firstName;  
            }
            set //set method
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

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
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
                return currentYear - birthYear;
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
        public int MaxHR
        {
            get
            {
                return (int)(CalculateMaxHR * 0.85);

            }
        }

        //propertie that calculate and return the person’s minimum target heart rate. 
        public int MinHR
        {
            get
            {
                return (int)(CalculateMaxHR * 0.5);

            }
        }

        //method that calculate and return the body mass index (BMI)
        public double BMINumericValue()
        {
            double bmi = weight * 703;
            bmi = bmi / (height * height);
            return Math.Round(bmi, 2);
            
        }

        //a method that return the BMI Text value depending on BMI computed numeric value
        public string BMITextValue()
        {
                if (BMINumericValue() < 18.5) return "Underweight";
                else if (BMINumericValue() >= 18.5 && BMINumericValue() <= 24.9) return "Normal";
                else if (BMINumericValue() >= 25 && BMINumericValue() < 29.9) return "Overweight";
                else if (BMINumericValue() >= 30) return "Obese";
                return null;
            
        }

        //public method DisplayHealthRecord, that display patient’s data in tabular form

        public void DisplayPatientRecord()
        {

            Borders();

            Console.WriteLine($"{"|",-26} {"PATIENT HEART RATE RECORD"}  {"|",28}");

            Borders();

            Console.WriteLine($"| {"Patient Name",-32} | {lastName + ", " + firstName,-44}|");
            
            Borders();

            Console.WriteLine($"| {"Patient Birth Year",-32} | {birthYear,43} |");

            Borders();

            Console.WriteLine($"| {"Patient Age",-32} | {CalulateAge,43} |");

            Borders();

            Console.WriteLine($"| {"Patient Height", -32} | {height,43} |");

            Borders();
            
            Console.WriteLine($"| {"Patient Weight",-32} | {weight,43} |");

            Borders();

            Console.WriteLine($"| {"Maximum Heart Rate",-32} | {CalculateMaxHR,43} |");
            
            Borders();

            Console.WriteLine($"| {"Targe Heart Rate Range",-32} | {MinHR + "-" +MaxHR,43} |");

            Borders();

            Console.WriteLine($"| {"BMI Numeric Value",-32} | {BMINumericValue(),43} |");

            Borders();

            Console.WriteLine($"| {"BMI Text Value",-32} | {BMITextValue(),-43} |");

            Borders();

            Console.WriteLine();
            Console.WriteLine();

            //“BMI Text Value”

            Border();
            Console.WriteLine($"{"|",-20} {"BMI TEST VALUES"}  {"|",24}");
            Border();
            Console.WriteLine($"| {"Less than 18.5", -24} | {"Underweight", -32}|");
            Border();
            Console.WriteLine($"| {"Between 18.5 and 24.9",-24} | {"Normal",-32}|");
            Border();
            Console.WriteLine($"| {"Between 25 and 29.9",-24} | {"Overweight",-32}|");
            Border();
            Console.WriteLine($"| {"30 or greater",-24} | {"Obese",-31} |");
            Border();

        }

        //a methode for creating the table's borders
        public void Borders()
        {
            Console.Write("|");
            for (int i = 0; i < 80; i++)
                Console.Write("-");
            Console.WriteLine("|");
        }

        public void Border()
        {
            Console.Write("|");
            for (int i = 0; i < 60; i++)
                Console.Write("-");
            Console.WriteLine("|");
        }

    }
}
