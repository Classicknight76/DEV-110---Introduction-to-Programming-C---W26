namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        // - Hometown (city, state)
        // - Favorite color
        // - Dream job
        // Hint: string variableName = Console.ReadLine();
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();
        Console.Write("Enter your hometown (city, state): ");
        string hometown = Console.ReadLine();
        Console.Write("Enter your favorite color: ");
        string favoriteColor = Console.ReadLine();
        Console.Write("Enter your dream job: ");
        string dreamJob = Console.ReadLine();

        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        // - GPA (double, 0.0-4.0)
        // - Graduation year (int)
        // - Is full-time student? (bool from yes/no)
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";
        Console.Write("Enter your major: ");
        string major = Console.ReadLine();
        Console.Write("Enter your GPA (0.0-4.0): ");
        double gpa = double.Parse(Console.ReadLine());
        Console.Write("Enter your graduation year: ");
        int graduationYear = int.Parse(Console.ReadLine());
        Console.Write("Are you a full-time student? (yes/no): ");
        string answer = Console.ReadLine();
        bool isFullTime = answer.ToLower() == "yes";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        // - Height in inches (double)
        // - Favorite number (int)
        Console.Write("Enter your age: ");
        int Age = int.Parse(Console.ReadLine());
        Console.Write("Enter your height in inches: ");
        double heightInches = double.Parse(Console.ReadLine());
        Console.Write("Enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        Console.Write($"Favorite Number: {favoriteNumber}");
        Console.Write($"Age: {Age}");
        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        // - Years to graduation = graduationYear - 2026
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        // - Is honor student? = gpa >= 3.5
        // - Age in months = age * 12
        int birthYear = 2026 - Age;
        int yearsToGraduation = graduationYear - 2026;
        int heightFeet = (int)(heightInches / 12);
        int heightRemainingInches = (int)(heightInches % 12);
        bool isHonorStudent = gpa >= 3.5;
        int ageInMonths = Age * 12;

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        // - PERSONAL INFORMATION
        // - ACADEMIC DETAILS
        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("\n════════════════ PERSONAL INFORMATION ════════════════");
        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Hometown: {hometown}");
        Console.WriteLine($"Favorite Color: {favoriteColor}");
        Console.WriteLine($"Dream Job: {dreamJob}");
        Console.WriteLine($"Favorite Number: {favoriteNumber}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine("\n════════════════ ACADEMIC DETAILS ════════════════");
        Console.WriteLine($"Major: {major}");
        Console.WriteLine($"GPA: {gpa:F2}");
        Console.WriteLine($"Graduation Year: {graduationYear}");
        Console.WriteLine($"Full-Time Student: {(isFullTime ? "Yes" : "No")}");
        Console.WriteLine("\n════════════════ CALCULATED STATISTICS ════════════════");
        Console.WriteLine($"Birth Year: {birthYear}");
        Console.WriteLine($"Years to Graduation: {yearsToGraduation}");
        Console.WriteLine($"Height: {heightFeet} ft {heightRemainingInches} in");
        Console.WriteLine($"Honor Student: {(isHonorStudent ? "Yes" : "No")}");
        Console.WriteLine($"Age in Months: {ageInMonths}");
        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
