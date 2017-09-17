using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace indexers
{
    public class Employee
    {
        public int empID { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
    }

    public class company
    {
        private List<Employee> listEmployee;

        public company()
        {
            listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { empID = 1, name = "Mike", gender = "Male" });
            listEmployee.Add(new Employee() { empID = 2, name = "Pam", gender = "Female" });
            listEmployee.Add(new Employee() { empID = 3, name = "Jim", gender = "Male" });
            listEmployee.Add(new Employee() { empID = 4, name = "Leslie", gender = "Female" });
            listEmployee.Add(new Employee() { empID = 5, name = "Nanqiao", gender = "Male" });
            listEmployee.Add(new Employee() { empID = 6, name = "Rich", gender = "Male" });
            listEmployee.Add(new Employee() { empID = 7, name = "Tyler", gender = "Male" });
            listEmployee.Add(new Employee() { empID = 8, name = "Ben", gender = "Male" });
        }

        public string this[int employeeID]
        {
            //this get method just retreives the name of the employee that matches the ID that is provided by the user. it just matches based on the user
            //provided ID and the ID in the database.
            get
            {
                return listEmployee.FirstOrDefault(emp => emp.empID == employeeID).name;
            }
            //this will find the employee with that ID then it will set the name that has been specified by the user.
            set
            {
                listEmployee.FirstOrDefault(emp => emp.empID == employeeID).name = value;
            }
        }
    }
}