using System;
using System.Collections.Generic;
using System.Text;
using EmployeeComponent.Data;
using EmployeeComponent.Views;

namespace EmployeeComponent
{
    public static class EmployeeObjectFactory
    {
        public static Employee CreateNewEmployeeObject(string firstName, string lastName, decimal annualSalary, char gender, bool isManager)
        {
            return new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                AnnualSalary = annualSalary,
                Gender = gender,
                IsManger = isManager
            };

        }

        public static EmployeeRecordsView EmployeeRecordsViewObject(Employees employees)
        {
            return new EmployeeRecordsView(employees);
        }


    }

}
