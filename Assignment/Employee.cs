using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }

        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public void HandleEmployeeLayOff(object sender, EmployeeLayOffEventArgs e)
        {
            Employee employee = (Employee)sender;
            Console.WriteLine($"Employee ID: {employee.EmployeeID} was laid off due to {e.Cause}");
        }

        public bool RequestVacation(DateTime from, DateTime to)
        {
            int requestedDays = (to - from).Days + 1;

            if (VacationStock >= requestedDays)
            {
                VacationStock -= requestedDays;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void EndOfYearOperation()
        {
            if (this is SalesPerson)
            {

            }
            else
            {
                if (VacationStock < 0)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStock0 });
                }
                else if ((DateTime.Now.Year - BirthDate.Year) > 60)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Age60 });
                }
            }
        }

    }
}
