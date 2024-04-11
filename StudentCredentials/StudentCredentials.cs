namespace StudentCredential
{
    public class StudentCredentials
    {
        public string StudentName;
        public string CourseSection;
        public double average;

        public StudentCredentials(string studName, string section, double aveGrade)
        {
            StudentName = studName;
            CourseSection = section;
            average = aveGrade;
        }

        public void DisplayCredentials()
        {
            Console.WriteLine("");
            Console.WriteLine("Student Name: " + StudentName);
            Console.WriteLine("Course and Section: " + CourseSection);
            Console.WriteLine("General Weighted Average: " + average);

            if (average >= 1.00 && average <= 1.50)
            {
                Console.WriteLine("Congratulations! You are a President Lister!!!");
            }
            else if (average > 1.50 && average <= 1.75)
            {
                Console.WriteLine("Congratulations! You are a Dean Lister!!!");
            }
            else
            {
                Console.WriteLine("Sorry, your grade is not qualified to be a President Lister or Dean Lister.");
            }

        }
    }
}
