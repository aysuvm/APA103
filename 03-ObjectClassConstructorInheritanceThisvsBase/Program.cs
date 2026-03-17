class Program
{
    static void Main(string[] args)
    {
        // Students
        Student s1 = new Student("Ali", "Mammadov", 20, "ali@mail.com", "S001",
                                "ST1001", "IT", 88.5, 2);

        Student s2 = new Student("Aysel", "Aliyeva", 21, "aysel@mail.com", "S002",
                                "ST1002", "Economics", 92.0, 3);

        Student s3 = new Student("Murad", "Hasanov", 19, "murad@mail.com", "S003",
                                "ST1003", "Engineering", 68.5, 1);

        // Teachers
        Teacher t1 = new Teacher("Rashad", "Karimov", 40, "rashad@mail.com", "T001",
                                 "IT", "Programming", 800, 15);

        Teacher t2 = new Teacher("Leyla", "Huseynova", 35, "leyla@mail.com", "T002",
                                 "Math", "Algebra", 800, 8);

        // Administrator
        Administrator admin = new Administrator("Nigar", "Rahimova", 45, "nigar@mail.com", "A001",
                                                "Dekan", "IT", 5);

        double totalScholarship = 0;
        decimal totalSalary = 0;

        // Student info
        Console.WriteLine("TƏLƏBƏLƏR ");
        Student[] students = { s1, s2, s3 };

        foreach (var s in students)
        {
            s.ShowStudentInfo();
            double scholarship = s.CalculateScholarship();
            Console.WriteLine($"Təqaüd: {scholarship} AZN\n");
            totalScholarship += scholarship;
        }

        // Teacher info
        Console.WriteLine(" MÜƏLLİMLƏR ");
        Teacher[] teachers = { t1, t2 };

        foreach (var t in teachers)
        {
            t.ShowTeacherInfo();
            decimal salary = t.CalculateSalary();
            Console.WriteLine($"Maaş: {salary} AZN\n");
            totalSalary += salary;
        }

        // Admin info
        Console.WriteLine("ADMIN");
        admin.ShowAdminInfo();

        // Grant access
        admin.GrantAccess(s1);

        // Statistics
        Console.WriteLine(" STATİSTİKA");
        Console.WriteLine($"Ümumi təqaüd xərci: {totalScholarship} AZN");
        Console.WriteLine($"Ümumi maaş xərci: {totalSalary} AZN");
    }
}
