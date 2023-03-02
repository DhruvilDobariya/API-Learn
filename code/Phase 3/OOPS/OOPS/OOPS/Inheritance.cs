namespace OOPS
{
    public class Inheritance
    {
        public static void Main(string[] args)
        {
            Student student = new Student(1, "Dhruvil Dobariya", 1, 8);
            student.DisplayStudent();

            Faculty faculty = new Faculty(2, "Bhargav Vachhani", 2, ".Net");
            faculty.DisplayFaculty();
        }
    }
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; } = string.Empty;

        public Person(int PersonId, string Name)
        {
            this.PersonId = PersonId;
            this.Name = Name;
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"PersonId: {PersonId}, Name: {Name}");
        }
    }
    public class Student : Person
    {
        public int StudentId { get; set; }
        public int Semester { get; set; }

        public Student(int personId, string name, int studentId, int semester) : base(personId, name)
        {
            StudentId = studentId;
            Semester = semester;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"PersonId: {base.PersonId}, StudentId: {StudentId}, Name: {base.Name}, Semester: {Semester}");
        }

        public void DisplayPersonFromStudent()
        {
            base.DisplayPerson();
        }
    }
    public class Faculty : Person
    {
        public int FacultyId { get; set; }
        public string Subject { get; set; } = string.Empty;

        public Faculty(int personId, string name, int facultyId, string subject) : base(personId, name)
        {
            FacultyId = facultyId;
            Subject = subject;
        }

        public void DisplayFaculty()
        {
            Console.WriteLine($"PersonId: {PersonId}, FacultyId: {FacultyId}, Name: {Name}, Subject: {Subject}");
        }
    }
}
