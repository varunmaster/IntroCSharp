using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesUsage
{
    class delegatesUsage
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, name = "Mary", salary = 5000, experience = 5 });
            empList.Add(new Employee() { ID = 102, name = "Mike", salary = 4000, experience = 4 });
            empList.Add(new Employee() { ID = 103, name = "Jack", salary = 6000, experience = 6 });
            empList.Add(new Employee() { ID = 104, name = "Ron", salary = 3000, experience = 3 });

            //1.a Employee.promoteEmp(empList);
            isPromotable isPromotable = new isPromotable(Promote);
            Employee.promoteEmp(empList, isPromotable);

            //this is a lambda expression. what this does is behind the scenes it creates a delegate, a function that has the same signature,
            //then passes it to the function below. this will get rid of the line "isPromotable ..." above. 
            //Employee.promoteEmp(empList, emp => emp.experience >= 5);
        }

        public static bool Promote (Employee emp) //2. the reason this is a bool method is because in the if statement in the promoteEmp method
                                                  //is of boolean type so we must match its signature to be used used in line under 1.a
        {
            if(emp.experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool isPromotable(Employee empl);

    class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }

        /// <summary>
        /// 1. here we have a static method that follows some sort of logic. However, if we want the logic to apply to some other criteria such as salary
        /// instead of experience then we have to manually change the method to follow this logic. We can instead use delegates to make the code dynamic.
        /// </summary>
        /*public static void promoteEmp(List<Employee> employeeList)
        {
            foreach(Employee employee in employeeList)
            {
                if(employee.experience >= 5)
                {
                    Console.WriteLine(employee.name + " promoted");
                }
            }
        }*/

        public static void promoteEmp(List<Employee> employeeList, isPromotable isEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (isEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.name + " promoted");
                }
            }
        }
    }
    /// <summary>
    /// So we have a list of employees that we want to potentially promote based on some sort of logic. The logic being that we want to promote them if
    /// they have 5 or more years of experience. We first created a method with hardcoding in the logic but the problem with that is that if we want to 
    /// change the logic to not be based on experience but rather salary, we then have to change the whole code. But if we had it dynamic then we wouldn't
    /// have to do that. The only thing we would have to change is the lambda operator or promote method. So in order to do this, we first create a 
    /// delegate that is of bool type (since the logic in the if statement was of bool type) called isPromotable. This delegate then takes in params 
    /// from employee class. Then the promoteEmp method takes in another argument which is the delegate. This parameter is called isEligibleToPromote
    /// which is another name for the delegate (kinda like a variable). Keep in mind that this delegate is a pointer to another function so the method is 
    /// really taking in a function as a parameter. We then pass the delegate into the if statement. We then call that variable, which is another name for 
    /// the delegate, to run through the employee list. In this part what it does is it takes the employee (ex. 101, Mary, 5000, 5) and then it refers it
    /// to the delegate where we declared it. This in turn points to the Promote method which will either return true or false depending on the experience
    /// and then it will do a console.writeline. A quicker way of doing this is to remove the Promote method and use a lambda expression where behind the
    /// scenes, it creates its own version of a Promote method and we dont have to write it out. Refer to the explanation of a lambda expression above.
    /// Finally, in order to run this, we have to create a new instance of the delegate and the promoteEmp method in the Main method.
    /// </summary>
}