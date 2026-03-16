class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Ali", "Mammadov", 20, "ali@mail.com", "P001", "ST1001", "IT", 88.5, 3);

        Student s2 = new Student("Nigar", "Aliyeva", 21, "nigar@mail.com", "P002", "ST1002", "IT", 92.0, 4);

        Student s3 = new Student("Murad", "Huseynov", 19, "murad@mail.com", "P003", "ST1003", "IT", 68.5, 2);


      
        Teacher t1 = new Teacher("Rashad", "Karimov", 40, "rashad@mail.com", "T001", "Computer Science", "Programming", 800, 15);

        Teacher t2 = new Teacher("Leyla", "Hasanova", 35, "leyla@mail.com", "T002", "Computer Science", "Databases", 800, 8);


        Administrator admin = new Administrator("Kamran", "Aliyev", 45, "kamran@mail.com", "A001", "Dekan", "IT Faculty", 5);


        double totalScholarship = 0;
        decimal totalSalary = 0;


      
        s1.ShowStudentInfo();
        Console.WriteLine("Təqaüd: " + s1.CalculateScholarship());
        totalScholarship += s1.CalculateScholarship();
        Console.WriteLine();

        s2.ShowStudentInfo();
        Console.WriteLine("Təqaüd: " + s2.CalculateScholarship());
        totalScholarship += s2.CalculateScholarship();
        Console.WriteLine();

        s3.ShowStudentInfo();
        Console.WriteLine("Təqaüd: " + s3.CalculateScholarship());
        totalScholarship += s3.CalculateScholarship();
        Console.WriteLine();


        t1.ShowTeacherInfo();
        Console.WriteLine("Maaş: " + t1.CalculateSalary());
        totalSalary += t1.CalculateSalary();
        Console.WriteLine();

        t2.ShowTeacherInfo();
        Console.WriteLine("Maaş: " + t2.CalculateSalary());
        totalSalary += t2.CalculateSalary();
        Console.WriteLine();


        admin.ShowAdminInfo();
        Console.WriteLine();

      
        admin.GrantAccess(s1);

        Console.WriteLine();
        Console.WriteLine(" Statistika");
        Console.WriteLine("Ümumi təqaüd xərci: " + totalScholarship);
        Console.WriteLine("Ümumi maaş xərci: " + totalSalary);
    }
}
