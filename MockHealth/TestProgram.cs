using System;

namespace MockHealth
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            try
            {
                //1. Create 2 objects of Health
                //ClassName objName = new Constructor(parameter list)
                Health objTest1 = new Health("John", "Smith", 1999, 60, 1.70);
                Health objTest2 = new Health("Sarah", "Doe", 2002, 45, 1.59);

                //2. Create an array of appropriate size and add the health objects to the array
                //string[] HealthObjectArray = new string[10];
                

                //3.  Display the details of each object using the DisplayDetails method
                objTest1.DisplayDetails();
                Console.WriteLine("");
                objTest2.DisplayDetails();
                Console.WriteLine("");

                //4. For the 1st object created, call the Age method/property and display the age of the person
                Console.WriteLine("The Age of Person 1 is: " + objTest1.Age().ToString());
                Console.WriteLine("");

                //5. For the 2nd object created call the MaxHeartRate and diaplay the details
                Console.WriteLine("The Maximum Heart Rate of Person 2 is: " + objTest2.MaxHeartRate().ToString());
                Console.WriteLine("");

                //6. For the 1st object, call the BMI Method and display the output
                Console.WriteLine("The BMI of Person 1 is: " + objTest1.BMI().ToString());
                Console.WriteLine("");

                //7. For the 2nd object, use the appropriate array index and call the Display Method

                //8. For the 2nd object, change the weight and height to different values
                objTest2.Weight = 42;
                objTest2.Height = 1.60;
                Console.WriteLine($"Updated weight: {objTest2.Weight}, \nUpdated height {objTest2.Height}");
                Console.WriteLine("");

                //9. For the 2nd object, call the BMI method to calculate the output
                Console.WriteLine("The BMI of Person 2 is: " + objTest2.BMI().ToString());                
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }// End Main
    }
}
