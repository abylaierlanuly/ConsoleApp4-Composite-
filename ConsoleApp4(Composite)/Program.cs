using System;
using System.Collections.Generic;

namespace ConsoleApp4_Composite_
{
    abstract class Employee
    {
        public string Name { get; set; }
        public abstract void AddSubordinate(Employee employee);
        public abstract void RemoveSubordinate(Employee employee);
        public abstract void Display();
    }

    class Manager : Employee
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        //testetst
        public override void AddSubordinate(Employee employee)
        {

            Employees.Add(employee);
        }

        public override void RemoveSubordinate(Employee employee)
        {
            Employees.Remove(employee);
        }

        public override void Display()
        {

            Console.WriteLine(Name);
            foreach (var item in Employees)
            {

                item.Display();
            }
        }
    }



    class Clerk : Employee
    {
        public List<Employee> Clerks { get; set; } = new List<Employee>();


        public override void AddSubordinate(Employee employee)
        {

            Clerks.Add(employee);
        }

        public override void RemoveSubordinate(Employee employee)
        {
            Clerks.Remove(employee);
        }

        public override void Display()
        {

            Console.WriteLine(Name);
            foreach (var item in Clerks)
            {

                item.Display();
            }
        }
    }


    class IT_specialist : Employee
    {
        public List<Employee> IT_specialists { get; set; } = new List<Employee>();


        public override void AddSubordinate(Employee employee)
        {

            IT_specialists.Add(employee);
        }

        public override void RemoveSubordinate(Employee employee)
        {
            IT_specialists.Remove(employee);
        }

        public override void Display()
        {
            Console.WriteLine(Name);
            foreach (var item in IT_specialists)
            {
                item.Display();
            }
        }

    }


    class Operator : Employee
    {

        public override void Display()
        {
            Console.WriteLine(Name);
        }

        public override void AddSubordinate(Employee component)
        {
            throw new NotImplementedException();
        }

        public override void RemoveSubordinate(Employee component)
        {
            throw new NotImplementedException();
        }

    }


    class ProgramClerk
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Менджеры:");
            Employee manager = new Manager() { Name = "Abylai" };
            Employee operaotOne = new Manager() { Name = "Bayngali" };
            Employee operaotTwo = new Manager() { Name = "Aibol" };
            manager.AddSubordinate(operaotOne);
            manager.AddSubordinate(operaotTwo);
            manager.Display();
            Console.WriteLine("\n");

            Console.WriteLine("IT-специалисты:");
            Employee it = new IT_specialist() { Name = "Abel" };
            Employee IT_specialist1 = new IT_specialist() { Name = "Kap" };
            Employee IT_specialist2 = new IT_specialist() { Name = "Dehan" };
            Employee IT_specialist3 = new IT_specialist() { Name = "Tomas" };
            it.AddSubordinate(IT_specialist1);
            it.AddSubordinate(IT_specialist2);
            it.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Служащие:");
            Employee Clerks = new Clerk() { Name = "Mario" };
            Employee Clerk1 = new Clerk() { Name = "Equinta" };
            Employee Clerk2 = new Clerk() { Name = "Kamil" };
            Clerks.AddSubordinate(Clerk1);
            Clerks.AddSubordinate(Clerk2);
            Clerks.Display();

        }
    }
}
