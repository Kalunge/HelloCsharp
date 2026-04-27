public class CodeChallenge
{
    public static void main()
    {
        calculateGrade();
    }

    private static void calculateGrade()
    {

        // initialize variables - graded assignments 
        int currentAssignments = 5;

        int[] sophiaGrades = { 90, 86, 87, 98, 100, 94, 90 };
        int[] andreScores = { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = { 90, 95, 87, 88, 96, 96 };
        int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 }; 

        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"};
        int[] studentSCores = new int[10];
        string currentStudentLetterGrade = "";
        
        
        Console.WriteLine("Student\t\tGrade\n");

        foreach (var name in studentNames)
        {
            string currentStudentName = name;

            if (currentStudentName == "Sophia")
                studentSCores = sophiaGrades;
            else if (currentStudentName == "Andrew")
                studentSCores = andreScores;
            else if (currentStudentName == "Emma")
                studentSCores = emmaScores;
            else if (currentStudentName == "Logan")
                studentSCores = loganScores;
            else if (currentStudentName == "Becky")
                studentSCores = beckyScores;
            else if (currentStudentName == "Chris")
                studentSCores = chrisScores;
            else if (currentStudentName == "Eric")
                studentSCores = ericScores;
            else if (currentStudentName == "Gregor")
                studentSCores = gregorScores;
            else
                continue;

            int sumAssignemtScores = sumGrades(studentSCores);
            decimal currentStudentGrade = (decimal)sumAssignemtScores / currentAssignments;

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
            
          
            Console.WriteLine($"{currentStudentName}:\t\t" + currentStudentGrade + $"\t{currentStudentLetterGrade}");
            
        }
        
        Console.WriteLine("Press the Enter key to continue");
        // Console.ReadLine();

        

    }

    private static int sumGrades(int[] grades)
    {
        int total = 0;
        int gradedAssignemnts = 0;

        foreach (var grade in grades)
        {
            gradedAssignemnts++;

            if (gradedAssignemnts <= 5)
            
                total += grade;
            
            else
                total += grade / 10;
            
        }
        
        


        return total;
    }


}

    
