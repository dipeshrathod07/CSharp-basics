using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;



namespace Csharp
{
   namespace Csharp
{
    class EmployeeDataTable
    {
       public static void Display()
        {
            EmployeeManagementSystem system = new EmployeeManagementSystem();

            // Add employees
            system.AddEmployee(1, "John Doe", "IT", 60000);
            system.AddEmployee(2, "Jane Smith", "HR", 50000);
            system.AddEmployee(3, "Sam Brown", "Finance", 55000);

            // Display all employees
            system.DisplayAllEmployees();

            // Update employee salary
            system.UpdateEmployeeSalary(2, 55000);

            // Delete an employee
            system.DeleteEmployee(3);

            // Display all employees after updates
            system.DisplayAllEmployees();

            // Filter employees by department
            system.FilterEmployeesByDepartment("IT");

            // Convert to List<Employee> and display
            List<Employee> employeeList = system.GetEmployeesAsList();
            Console.WriteLine("\nEmployees as List:");
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"ID: {employee.EmployeeID}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
            }
        }

        // Employee and EmployeeManagementSystem classes remain the same
    }
}

        class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }
        }

        class EmployeeManagementSystem
        {
            private DataSet dataSet;
            private DataTable employeeTable;

            public EmployeeManagementSystem()
            {
                dataSet = new DataSet();
                InitializeDataTable();
            }

            private void InitializeDataTable()
            {
                employeeTable = new DataTable("Employees");

                // Define columns for Employee DataTable
                employeeTable.Columns.Add("EmployeeID", typeof(int));
                employeeTable.Columns.Add("Name", typeof(string));
                employeeTable.Columns.Add("Department", typeof(string));
                employeeTable.Columns.Add("Salary", typeof(decimal));

                // Set EmployeeID as the primary key
                employeeTable.PrimaryKey = new DataColumn[] { employeeTable.Columns["EmployeeID"] };

                // Add DataTable to DataSet
                dataSet.Tables.Add(employeeTable);
            }

            // Add a new employee
            public void AddEmployee(int employeeID, string name, string department, decimal salary)
            {
                DataRow row = employeeTable.NewRow();
                row["EmployeeID"] = employeeID;
                row["Name"] = name;
                row["Department"] = department;
                row["Salary"] = salary;
                employeeTable.Rows.Add(row);
            }

            // Update employee salary
            public void UpdateEmployeeSalary(int employeeID, decimal newSalary)
            {
                DataRow row = employeeTable.Rows.Find(employeeID);
                if (row != null)
                {
                    row["Salary"] = newSalary;
                    Console.WriteLine($"Employee {employeeID}'s salary updated to {newSalary}.");
                }
                else
                {
                    Console.WriteLine($"Employee with ID {employeeID} not found.");
                }
            }

            // Delete an employee
            public void DeleteEmployee(int employeeID)
            {
                DataRow row = employeeTable.Rows.Find(employeeID);
                if (row != null)
                {
                    employeeTable.Rows.Remove(row);
                    Console.WriteLine($"Employee {employeeID} deleted.");
                }
                else
                {
                    Console.WriteLine($"Employee with ID {employeeID} not found.");
                }
            }

            // Convert DataTable to List<Employee>
            public List<Employee> GetEmployeesAsList()
            {
                return employeeTable.AsEnumerable()
                                    .Select(row => new Employee
                                    {
                                        EmployeeID = row.Field<int>("EmployeeID"),
                                        Name = row.Field<string>("Name"),
                                        Department = row.Field<string>("Department"),
                                        Salary = row.Field<decimal>("Salary")
                                    }).ToList();
            }

            // Filter employees by department
            public void FilterEmployeesByDepartment(string department)
            {
                List<Employee> employees = GetEmployeesAsList();
                var filteredEmployees = employees.Where(e => e.Department == department).ToList();

                Console.WriteLine($"Employees in department: {department}");
                foreach (var employee in filteredEmployees)
                {
                    Console.WriteLine($"ID: {employee.EmployeeID}, Name: {employee.Name}, Salary: {employee.Salary}");
                }
            }

            // Display all employees
            public void DisplayAllEmployees()
            {
                Console.WriteLine("All Employees:");
                foreach (DataRow row in employeeTable.Rows)
                {
                    Console.WriteLine($"ID: {row["EmployeeID"]}, Name: {row["Name"]}, Department: {row["Department"]}, Salary: {row["Salary"]}");
                }
            }
        }
    }

