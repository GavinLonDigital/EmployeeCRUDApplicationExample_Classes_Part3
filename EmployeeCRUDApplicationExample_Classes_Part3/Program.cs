using EmployeeComponent;
using EmployeeComponent.Data;
using EmployeeComponent.Views;
using System;

namespace EmployeeCRUDApplicationExample_Classes_Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();

            EmployeeRecordsView employeeRecordsView = new EmployeeRecordsView(employees);

            Console.WriteLine(EmployeeCommonOutputText.GetApplicationHeading());

            employeeRecordsView.RunRecordsView();

            Console.ReadKey();

        }
    }
}
