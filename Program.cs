// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }
// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");
// using System;

// class Program
// {
//     static void Main()
//     {
//         string[] output = {
//             "B123",
//             "C234",
//             "A345",
//             "C15",
//             "B177",
//             "G3003",
//             "C235",
//             "B179"
//         };

//         foreach (string line in output)
//         {
//             Console.WriteLine(line);
//         }
//     }
// }
// string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// foreach (string orderID in orderIDs)
// {
//    if (orderID.StartsWith("A") || orderID.StartsWith("B"))
//     {
//         Console.WriteLine(orderID);
//     }
// }
// initialize variables - graded assignments 
// int currentAssignments = 5;

// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;

// int sophiaSum = 0;
// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;

// decimal sophiaScore;
// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

// sophiaScore = sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();
// initialize variables - graded assignments 
// initialize variables - graded assignments 
// initialize variables - graded assignments 
// initialize variables - graded assignments
using System;

class Program
{
    static void Main()
    {
        int currentAssignments = 5;

        // Scores for each student
        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

        // Student names
        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

        // Extra credit points (example values)
        decimal[] extraCreditPoints = new decimal[] { 3.68m, 1.78m, 5.34m, 1.92m };

        // Initialize a new line to be printed
        Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit");

        for (int i = 0; i < studentNames.Length; i++)
        {
            string name = studentNames[i];
            int[] studentScores;
            decimal extraCredit = extraCreditPoints[i];

            // Assign scores based on student name
            if (name == "Sophia")
                studentScores = sophiaScores;
            else if (name == "Andrew")
                studentScores = andrewScores;
            else if (name == "Emma")
                studentScores = emmaScores;
            else // Logan
                studentScores = loganScores;

            // Calculate the sum of the scores
            int sumAssignmentScores = 0;
            foreach (int score in studentScores)
            {
                sumAssignmentScores += score;
            }

            // Calculate the average score
            decimal currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

            // Determine the letter grade
            string currentStudentLetterGrade = "";
            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";
            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";
            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";
            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";
            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";
            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";
            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";
            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";
            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";
            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";
            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";
            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";
            else
                currentStudentLetterGrade = "F";

            // Display results
            Console.WriteLine($"{name}\t\t{currentStudentGrade:F1}\t\t{currentStudentLetterGrade}\t\t{extraCredit:F2} pts");
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}
