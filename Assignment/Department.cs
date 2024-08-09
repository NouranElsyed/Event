using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{


    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        public List<Employee> Staff;

        public Department()
        {
            Staff = new List<Employee>();
        }

        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
        }

        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            Employee employee = sender as Employee;
            if (employee != null)
            {
                Staff.Remove(employee);
                Console.WriteLine($"Employee ID: {employee.EmployeeID} was removed from {DeptName} due to {e.Cause}");
            }
        }
    }



}
