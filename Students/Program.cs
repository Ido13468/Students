class Student: IPerson
{
    protected string StudentName;
    protected int StudentID;
    protected int Age;



    public Student(string studentName, int studentID, int age)
    {
        this.StudentName = studentName;
        this.StudentID = studentID;
        this.Age = age;
    }

    public void SetAge(int num)
    {
        this.Age = num;
    }


    public virtual void DisplayInformation()
    {
        Console.WriteLine($"Name: {this.StudentName}, ID: {this.StudentID}, Age: {this.Age}");
    }

    public (string name, int id, int age) GetStudentInfo()
    {
        return (this.StudentName, this.StudentID, this.Age);
    }

}

interface IPerson
{
    void DisplayInformation();
}

class CollegeStudent : Student
{
    private string major;
    private int Average;

    public CollegeStudent(string name, int id, int age, string major, int averageGrade)
        : base(name, id, age)
    {
        this.major = major;
        this.Average = averageGrade;
    }

    public void SetMajor(string str)
    {
        this.major = str;
    }

    public override void DisplayInformation()
    {
        Console.WriteLine($"Name: {this.StudentName}, ID: {this.StudentID}, Age: {this.Age}, Major: {this.major}, Average: {this.Average}");
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Student s1 = new Student("Ido", 123456789, 16);

        CollegeStudent cs1 = new CollegeStudent("Dvir", 987654321, 22, "Computer Science", 93);

        s1.SetAge(17);
        cs1.SetMajor("Software Engineering");


        IPerson[] people = new IPerson[1];
        people[0] = s1;
        people[1] = cs1;
        foreach (IPerson person in people)
        {
            person.DisplayInformation();
        }
    }
}