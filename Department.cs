using System;
using System.Collections.Generic;
using System.Text;

namespace LAB08_1
{
    public class Department
    {
        public string Name { get; set; }
        private List<Employee> employees;

        public Department(string name)
        {
            Name = name;
            employees = new List<Employee>();
        }

        public bool AddEmployee(Employee employee)
        {
            if (employees == null)        //если нет
            {
                return false;
            }

            foreach (Employee emp in employees)
            {
                if (emp.ID == employee.ID)         //на дубликат если такой есть уже
                {
                    return false;
                }
            }

        employees.Add(employee);
        return true;
        }

        public bool RemoveEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == id)
                {
                    employees.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int CountEmployees()
        {
            return employees.Count;
        }

        public int CountWorkers()
        {
            int count = 0;

            foreach(Employee emp in employees)
            {
                if(emp is Worker)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountManagers()
        {
            int count = 0;

            foreach (Employee emp in employees)
            {
                if (emp is Manager)
                {
                    count++;
                }
            }
            return count;
        }
        public int CountProgrammers()
        {
            int count = 0;

            foreach (Employee emp in employees)
            {
                if (emp is Programmer)
                {
                    count++;
                }
            }
            return count;
        }

        public decimal CalculateTotalSalary()
        {
            decimal total = 0;
            
            foreach(Employee emp in employees)
            {
                total += emp.TotalSalary();
            }

            return total;
        }

        public decimal CalculateAverageSalary()
        {
            if (employees.Count == 0)
            {
                return 0;
            }
            return CalculateTotalSalary() / employees.Count;
        }

        public Employee ? FindEmployee(int id)
        {
            foreach(Employee emp in employees)
            {
                if(emp.ID == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public Employee? FindHighestPaidEmployee()
        {
            if (employees.Count == 0)
            {
                return null;
            }

            Employee highest = employees[0];
            foreach (Employee emp in employees)
            {
                if (emp.TotalSalary() > highest.TotalSalary())
                {
                    highest = emp;
                }
                
            }
            return highest;
        }
      
        public Employee? FindLowetsPaidEmployee()
        {
            if (employees.Count == 0)
            {
                return null;
            }

            Employee lowest = employees[0];
            foreach (Employee emp in employees)
            {
                if (emp.TotalSalary() < lowest.TotalSalary())
                {
                    lowest = emp;
                }

            }
            return lowest;
        }

        public decimal CalculateAverageSalaryByType(string type)
        {
            decimal total = 0;
            int count = 0;

            foreach(Employee emp in employees)
            {
                if(emp.GetType().Name == type)
                {
                    total += emp.TotalSalary();
                    count++;
                }
            }

            if(count == 0)
            {
                return 0;
            }
            return total / count;
        }

        public void PrintEmployees()
        {
            Console.WriteLine($"Department: {Name}");
            Console.WriteLine("---------------------------------");

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
