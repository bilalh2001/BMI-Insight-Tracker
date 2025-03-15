using System;

namespace BMIInsightTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the BMI Insight Tracker!");

            // Collect user input
            Console.Write("Enter your weight in kilograms: ");
            if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for weight.");
                return;
            }

            Console.Write("Enter your height in meters: ");
            if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for height.");
                return;
            }

            // BMI calculation
            double bmi = weight / (height * height);

            // Display BMI result
            Console.WriteLine($"Your BMI is: {bmi:F2}");

            // Health recommendation
            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight. Consider consulting with a nutritionist.");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("You have a normal weight. Keep up the good work!");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("You are overweight. A balanced diet and regular exercise can help.");
            }
            else
            {
                Console.WriteLine("You are obese. Seeking medical advice is recommended.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
