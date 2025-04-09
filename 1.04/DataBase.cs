using System;
namespace Employee_DataBase;


public class DataBase
{
    public static void ReadInfo(Employee employee)
    {
        Console.WriteLine($"Age:{employee.Age} | " + $"Name: {employee.Name} | " + $"Surname: {employee.Surname} | " +
                          $"Position: {employee.Position}");
    }

    public static Employee AddEmployee()
    {
        int age = 0;
        bool IsWorking1 = true;
        do
        {
            try
            {
                Console.Write("What`s your age: ");
                int age1 = int.Parse(Console.ReadLine());
                age = age1;
                IsWorking1 = false;
            }
            catch
            {
                Console.WriteLine("Invalid input || Try again");
            }
        } while (IsWorking1 != false);

        Console.Write("What`s your name: ");
        string name = Console.ReadLine();
        Console.Write("What`s your surname: ");
        string surname = Console.ReadLine();
        Console.Write("What`s your position: ");
        string position = Console.ReadLine();
        
        Employee employee = new Employee(age, position, surname, name);
        return employee;
    }

    public static void ChangeInfo(List<Employee> dt, int number)
    {
        int age = 0;
        bool IsWorking1 = true;
        do
        {
            try
            {
                Console.Write("What`s your age: ");
                int age1 = int.Parse(Console.ReadLine());
                age = age1;
                IsWorking1 = false;
            }
            catch
            {
                Console.WriteLine("Invalid input || Try again");
            }
        } while (IsWorking1 != false);

        Console.Write("What`s your name: ");
        string name = Console.ReadLine();
        Console.Write("What`s your surname: ");
        string surname = Console.ReadLine();
        Console.Write("What`s your position: ");
        string position = Console.ReadLine();

        dt[number].Name = name;
        dt[number].Position = position;
        dt[number].Age = age;
        dt[number].Surname = surname;
    }

    public static void ClearInfo(List<Employee> dt)
    {
        dt.Clear();
    }
    public static void ClearEmployeeInfo(int index , List<Employee> dt)
    {
        dt.RemoveAt(index);
    }
}