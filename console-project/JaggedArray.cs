using System.Data;

namespace Csharp
{
    class JaggedArray
    {
        public static void Display()
        {
        Console.Write("Enter number of days: ");
        int numberOfDays = int.Parse(Console.ReadLine());

        // Create a jagged array to store absent roll numbers for each day
        int[][] absentRollNumbers = new int[numberOfDays][];

        // Input attendance for each day
        for (int i = 0; i < numberOfDays; i++)
        {
            Console.WriteLine($"\nEnter attendance for Day {i + 1}:");
            Console.Write("Enter number of students absent: ");
            int numberOfAbsentStudents = int.Parse(Console.ReadLine());

            absentRollNumbers[i] = new int[numberOfAbsentStudents];

            Console.Write("Enter absent roll numbers: ");
            string[] rollNumbers = Console.ReadLine().Split(' ');

            for (int j = 0; j < numberOfAbsentStudents; j++)
            {
                absentRollNumbers[i][j] = int.Parse(rollNumbers[j]);
            }
        }
        
        // Display absent roll numbers for each day
        Console.WriteLine("\nAbsent roll numbers:");
        for (int i = 0; i < numberOfDays; i++)
        {
            Console.Write($"Day {i + 1}: ");
            Console.WriteLine(string.Join(" ", absentRollNumbers[i]));
        }
    
        }
    }
}