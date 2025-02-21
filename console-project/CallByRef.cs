
namespace Csharp
{
    class CallByRef
    {
        public static void Display()
        {
            Console.Write("Enter student's name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter grade (optional, default is B): ");
            string gradeInput = Console.ReadLine();
            string grade = string.IsNullOrWhiteSpace(gradeInput) ? "B" : gradeInput;

            Console.Write("Enter initial score: ");
            int initialScore = int.Parse(Console.ReadLine());

            // Display student's name and grade using the function with default parameter
            DisplayStudentInfo(studentName, grade);

            // Update the score using the function with ref parameter
            int updatedScore = initialScore;
            UpdateScoreWithBonus(ref updatedScore, grade);

            // Display the initial and updated scores
            Console.WriteLine($"Initial Score: {initialScore}");
            Console.WriteLine($"Updated Score with Bonus: {updatedScore}");

        }
        static void DisplayStudentInfo(string name, string grade = "B")
        {
            Console.WriteLine($"\nStudent: {name}, Grade: {grade}");
        }

        // Function with a ref parameter
        static void UpdateScoreWithBonus(ref int score, string grade)
        {
            switch (grade)
            {
                case "A":
                    score += 10;
                    break;
                case "B":
                    score += 5;
                    break;
                case "C":
                    // No bonus for grade C
                    break;
                default:
                    Console.WriteLine("Invalid grade. No bonus applied.");
                    break;
            }
        }

    }
}



