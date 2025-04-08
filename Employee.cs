namespace Employee_DataBase;

public class Employee
{
    public int Age { get; set; }
    public string Position { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }

    public Employee(int age, string position, string surname, string name)
    {
        this.Age = age;
        this.Position = position;
        this.Surname = surname;
        this.Name = name;
    }
}