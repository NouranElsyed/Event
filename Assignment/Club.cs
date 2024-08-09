using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        public List<Employee> Members;

        public Club()
        {
            Members = new List<Employee>();
        }

        public void AddMember(Employee E)
        {
            Members.Add(E);

            E.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee employee = sender as Employee;
            if (employee != null)
            {
                if (e.Cause == LayOffCause.VacationStock0)
                {

                    Members.Remove(employee);
                    Console.WriteLine($"Employee ID: {employee.EmployeeID} was removed from Club: {ClubName} due to {e.Cause}");
                }
                else if (e.Cause == LayOffCause.Age60)
                {

                    Console.WriteLine($"Employee ID: {employee.EmployeeID} was NOT removed from Club: {ClubName} despite reaching age 60");
                }
            }
        }
    }
}
