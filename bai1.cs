using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; } 
    public virtual void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Student : Person
{
    public string StudentId { get; set; }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("StudentID: " + StudentId);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student
        {
            Name = "John Doe",
            Age = 20,
            StudentId = "S12345",
        };
        /*
        Console.WriteLine("Nhap ten:");
        student.Name = Console.ReadLine();
        Console.WriteLine("Nhap tuoi:");
        student.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap ma sinh vien:");
        student.StudentId = Console.ReadLine();
        */
        

        student.ShowInfo();
    }
}