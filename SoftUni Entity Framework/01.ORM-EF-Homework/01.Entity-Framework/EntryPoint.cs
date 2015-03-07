using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Entity_Framework
{
    class Program
    {
        static SoftUniEntities db = new SoftUniEntities();

        static void Main(string[] args)
        {
            Console.Write("Write the problem's number (3, 4, 5, 8, 9): ");
            var whichProblem = int.Parse(Console.ReadLine());

            switch (whichProblem)
            {
                case 3:
                    Console.WriteLine("Employees with projects that start during 2002:");
                    Console.WriteLine();
                    EmployeesWithProjectsStartedDuring2002();
                    break;
                case 4:
                    Console.WriteLine("Employees with projects that start during 2002 SQL:");
                    Console.WriteLine();
                    EmployeesWithProjectsStartedDuring2002SQL();
                    break;
                case 5:
                    Console.WriteLine("Employees by department name and manager's first and last name");
                    Console.WriteLine("For example: Department Name: Production; Manager name: Jo Brown");
                    Console.WriteLine();

                    Console.Write("Department name: ");
                    var departmentName = Console.ReadLine();

                    Console.Write("Manager first and last name (seperated by space): ");
                    var managerName = Console.ReadLine();

                    FindEmployeesByDepartmentAndManager(departmentName, managerName);
                    break;
                case 8:
                    Console.WriteLine("Insert a new project");
                    InsertNewProject();
                    break;
                case 9:
                    Console.WriteLine("Call stored procedure");
                    Console.Write("Employee first and last name (seperated by space): ");
                    var employeeName = Console.ReadLine();
                    FindProjectsByEmployee(employeeName);
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
           
        }

        private static void EmployeesWithProjectsStartedDuring2002()
        {
            var projects = db.Projects.Where(p => p.StartDate.Year == 2002);

            foreach (var project in projects)
            {
                foreach (var employee in project.Employees)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }
        }

        private static void EmployeesWithProjectsStartedDuring2002SQL()
        {
            var employees = db.Database.SqlQuery<string>("SELECT e.FirstName + ' ' + e.LastName " +
                "FROM Employees e " +
                "JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID " +
                "JOIN Projects p ON ep.ProjectID = p.ProjectID " +
                "WHERE YEAR(p.StartDate) = 2002").ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static void FindEmployeesByDepartmentAndManager(string departmentName, string managerFullName)
        {
            var managerNames = managerFullName.Split(' ');
            var managerFirstName = managerNames[0];
            var managerLastName = managerNames[1];

            var employees = db.Employees.Where(e => e.Department.Name == departmentName && e.Employee1.FirstName == managerFirstName && e.Employee1.LastName == managerLastName);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
        }

        private static void InsertNewProject()
        {
            Console.Write("Project name: ");
            var projectName = Console.ReadLine();

            Console.Write("Project start date (in format dd/mm/yyyy): ");
            var projectStartDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);


            Console.Write("How many employees does this project have: ");
            var numberOfEmployees = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            Console.WriteLine("Write the employee first and last name (seperated by space). If a employee with this name is found " +
                " he will be used. If multiple employees are found the first one found will be used. If no employee is found " +
                "a employee with the given name and default values for the other parameters will be created.");

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.Write("Employee name: ");
                var employeeName = Console.ReadLine();
                var employee = FindEmployeeByNameOrCreateNew(employeeName);
                employees.Add(employee);
            }

            var project = new Project 
            {
                Name = projectName,
                StartDate = projectStartDate,
                Employees = employees
            };

            db.Projects.Add(project);
            db.SaveChanges();
            Console.WriteLine("Project successfully added");
        }

        private static Employee FindEmployeeByNameOrCreateNew(string employeeFullName)
        {
            var employeeNames = employeeFullName.Split(' ');
            var employeeFirstName = employeeNames[0];
            var employeeLastName = employeeNames[1];

            var employee = db.Employees.FirstOrDefault(e => e.FirstName == employeeFirstName && e.LastName == employeeLastName);
            if (employee != null) {
                return employee;
            }
            else
            {
                return new Employee
                {
                    FirstName = employeeFirstName,
                    LastName = employeeLastName,
                    JobTitle = "Razbirach na vsichko",
                    DepartmentID = 1,
                    HireDate = DateTime.Now.AddYears(-3),
                    Salary = 1
                };
            }
        }

        private static void FindProjectsByEmployee(string employeeFullName)
        {
            var employeeNames = employeeFullName.Split(' ');
            var employeeFirstName = employeeNames[0];
            var employeeLastName = employeeNames[1];

            var projects = db.udp_FindAllProjectsForEmployee(employeeFirstName, employeeLastName).ToList();
            Console.WriteLine("Project names:");
            if (projects.Count != 0)
            {
                foreach (var project in projects)
                {
                    Console.WriteLine(project);
                }
            }
            else
            {
                Console.WriteLine("This employee either does not exists, either he has no projects");
            }
        }
    }
}
