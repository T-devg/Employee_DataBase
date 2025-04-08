
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_DataBase
{
    class Programm
    {
        static void Main(string[] args)
        {
        do
        {
            
            List<Employee> Db = new List<Employee>();
            Db.Add(DataBase.AddEmployee());
               Selector:
                Console.WriteLine();
                Console.WriteLine("Possible actions ( type number ) : ");
                Console.WriteLine("1 - Exit");
                Console.WriteLine("2 - Add new employee");
                Console.WriteLine("3 - Read information");
                Console.WriteLine("4 - Change information");
                Console.WriteLine("5 - Delete information");
                Console.Write(">");
                var answer = Console.ReadLine();
                
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Goodbye! || See you soon");
                        Environment.Exit(0);
                        break;
                    case "2":
                        Db.Add(DataBase.AddEmployee());
                        goto Selector;
                     case "3":
                        for (int i = 0; i < Db.Count; i++)
                        {
                            Console.Write(i+". ");
                            DataBase.ReadInfo(Db[i]);
                        }
                        Console.WriteLine();
                        goto Selector;
                     case "4" :
                            Console.WriteLine("Employee number in the list: ");
                            int EmpNumber = int.Parse(Console.ReadLine());
                            DataBase.ChangeInfo(Db, EmpNumber);
                        
                        goto Selector;
                         
                     case "5":
                         DataBase.ClearInfo(Db);
                         goto Selector;
                }
                
            } while (true);
            
        }
    }
}
