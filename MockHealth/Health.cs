using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockHealth
{
    class Health
    {
        //1. Create Instance Variable - IV (PRIVATE & LOWER CASE) --> Needs to be implemented in 3. Implemented Properties
        private int birthYear;
        private int weight;
        private double height;

        //2. Auto-Implemented Properties --> No need to validate - String DType
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //3. Implemented Properties
        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                if (value > 0)
                {
                    birthYear = value;
                }
            }

        }// end of BirthYear

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }// end of Weight

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0.0)
                {
                    height = value;
                }
            }
        }// end of Height


        //4. Parameterless Constructor

        //5. Parameterised Constructor
        public Health(string _firstName, string _lastName, int _birthYear, int _weight, double _height)
        {
            //Properties = Parameters
            FirstName = _firstName;
            LastName = _lastName;
            BirthYear = _birthYear;
            Weight = _weight;
            Height = _height;
        }

        //6. Methods


        /// <summary>
        /// Purpose: A method/property called "Age"
        /// </summary>
        /// <returns>Returns the person's age based on birthYear</returns>
        public int Age()
        {
            int age;
            age = 2021 - birthYear;
            return age;
        }

        /// <summary>
        /// Purpose: A Method/Property called "MaxHeartRate"
        /// </summary>
        /// <returns>Returns the person's maximum heart rate</returns>
        public int MaxHeartRate()
        {
            int maxHeartRate;
            maxHeartRate = 220 - Age();
            return maxHeartRate;
        }

        /// <summary>
        /// Purpose: A Method called BMI
        /// </summary>
        /// <returns>Returns a string that includes BMI and BMI Range</returns>
        public double BMI()
        {
            double bmi;
            bmi = (Weight / (Height * Height));
            
            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi >=18.5 && bmi <25)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
            
            return bmi;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName} \tBirth year: {BirthYear} \tWeight: {Weight}" +
                $"\tHeight: {Height} \tAge: {Age()} \tMaximum Heart Rate {MaxHeartRate()} \tBMI: {BMI()}");
        }


    }// End of Class - NO CODES AFTER THIS CURLY BRACKET
}// End of Namespace
