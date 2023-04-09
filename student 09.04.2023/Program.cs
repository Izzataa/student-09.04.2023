
internal class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Point;
    public bool IsGraduated;

    public Student(string Name, string Surname, string Group, double Point, bool IsGraudet)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Group = Group;
        this.Point = Point;
        this.IsGraduated = IsGraudet;
    }

    public string GetFullName()
    {
        return $"{Name} {Surname}";
    }
    public string GetAllInfo()
    {
        string info = $"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}";
        if (IsGraduated)
        {
            info += ",Graduated ";
        }
        else
        {
            info += ", Not Graduated";
        }
        return info;
    }
    public bool CanTakeNextExam()
    {
        return Point > 80;
    }
}
