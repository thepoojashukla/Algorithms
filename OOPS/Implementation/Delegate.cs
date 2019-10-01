using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    class Delegate
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() {Id = 101, Name = "John", Salary = 1000 , Experience = 5});
            emplist.Add(new Employee() { Id = 101, Name = "Betty", Salary = 7000, Experience = 3 });
            emplist.Add(new Employee() { Id = 101, Name = "Richard", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { Id = 101, Name = "Dev", Salary = 3000, Experience = 2 });

            //IsPromotable delpromote = new IsPromotable(PromotableEmp);
            //Employee.PromoteEmployee(emplist,delpromote);

            Employee.PromoteEmployee(emplist, emp => emp.Salary > 3000);  //without passing delegate just using Lamda expression
        }

       /* public static bool PromotableEmp(Employee empPromote)
        {
            if (empPromote.Salary > 3000)
            {
                Console.WriteLine(empPromote.Name + "" + "Promoted");
                return true;
            }
            else return false;
        }*/
    }

    delegate bool IsPromotable(Employee emp);

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList,IsPromotable promote)
        {
            foreach(Employee employee in employeeList)
            {
                if(promote(employee))
                {
                    Console.WriteLine(employee.Name + "" + "Promoted");
                }
            }
        }

        /*public static void PromoteEmployee(List<Employee> employeeList )
        {
            foreach(Employee employee in employeeList)
            {                                                  //Hard code
                if(employee.Salary > 3000)
                {
                    Console.WriteLine(employee.Name + "" + "Promoted");
                }
            }
        }*/
    }
    
}
