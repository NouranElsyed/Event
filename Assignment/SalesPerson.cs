using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        public bool CheckTarget(int Quota)
        {
            return AchievedTarget >= Quota;
        }

        public override void EndOfYearOperation()
        {
            int salesQuota = 100;

            if (!CheckTarget(salesQuota))
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.TargetNotAchieved });
            }
        }
    }
}
