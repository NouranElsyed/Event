using System.Transactions;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Employee emp1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1950, 5, 23), VacationStock = 10 };
            //Employee emp2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1990, 7, 15), VacationStock = -5 };
            //Employee emp3 = new Employee { EmployeeID = 3, BirthDate = new DateTime(1985, 12, 5), VacationStock = 15 };
            //Employee emp4 = new Employee { EmployeeID = 4, BirthDate = new DateTime(1962, 3, 1), VacationStock = 3 };
            //Employee[] employees = { emp1, emp2, emp3, emp4 };


            //Department dept = new Department() { DeptID = 1, DeptName = "IT" };
            //dept.AddStaff(emp1);
            //dept.AddStaff(emp2);
            //dept.AddStaff(emp3);
            //dept.AddStaff(emp4);

            //Club club = new Club { ClubID = 1, ClubName = "Fitness Club" };
            //club.AddMember(emp1);
            //club.AddMember(emp2);
            //club.AddMember(emp3);
            //club.AddMember(emp4);


            //foreach (var employee in employees)
            //{
            //    employee.EndOfYearOperation();
            //}



            SalesPerson salesPerson1 = new SalesPerson { EmployeeID = 1, BirthDate = new DateTime(1985, 4, 12), AchievedTarget = 80 };
            SalesPerson salesPerson2 = new SalesPerson { EmployeeID = 2, BirthDate = new DateTime(1990, 7, 25), AchievedTarget = 120 };

            BoardMember boardMember1 = new BoardMember { EmployeeID = 3, BirthDate = new DateTime(1945, 3, 10) };
            BoardMember boardMember2 = new BoardMember { EmployeeID = 4, BirthDate = new DateTime(1955, 8, 19) };

          
            Club club = new Club { ClubID = 1, ClubName = "Executive Club" };
            Department department = new Department { DeptID = 1, DeptName = "Sales" };

            club.AddMember(salesPerson1);
            club.AddMember(salesPerson2);
            club.AddMember(boardMember1);
            club.AddMember(boardMember2);

            department.AddStaff(salesPerson1);
            department.AddStaff(salesPerson2);
            department.AddStaff(boardMember1);
            department.AddStaff(boardMember2);

            Console.WriteLine("\nDepartment Staff Before End of Year Operations:");
            foreach (var staff in department.Staff)
            {
                Console.WriteLine($"Employee ID: {staff.EmployeeID}");
            }

            Console.WriteLine("\nClub Members Before End of Year Operations:");
            foreach (var member in club.Members)
            {
                Console.WriteLine($"Employee ID: {member.EmployeeID}");
            }


            salesPerson1.EndOfYearOperation(); 
            salesPerson2.EndOfYearOperation(); 
            boardMember1.Resign();
            boardMember2.EndOfYearOperation();

            Console.WriteLine("\nDepartment Staff after End of Year Operations:");
            foreach (var staff in department.Staff)
            {
                Console.WriteLine($"Employee ID: {staff.EmployeeID}");
            }

            Console.WriteLine("\nClub Members after End of Year Operations:");
            foreach (var member in club.Members)
            {
                Console.WriteLine($"Employee ID: {member.EmployeeID}");
            }




        }
    }










}
   