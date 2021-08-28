﻿using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Pera",
                LastName = "Peric",
                Email = "pera@dramin-ns.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/pera.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Mika",
                LastName = "Mikic",
                Email = "mika@dramin-ns.com",
                DateOfBirth = new DateTime(1975, 1, 15),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/mika.png"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Igor",
                LastName = "Mudrinic",
                Email = "igor@dramin-ns.com",
                DateOfBirth = new DateTime(1975, 1, 15),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/igor.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Sara",
                LastName = "Saric",
                Email = "sara@dramin-ns.com",
                DateOfBirth = new DateTime(1975, 1, 15),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/sara.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
