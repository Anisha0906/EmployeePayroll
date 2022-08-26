namespace EmployeePayroll
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage");
            Console.WriteLine("Choose Option\n 1.Check Absent or Present");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    EmployeeCheckAttendance.EmployeePresentAbsent();
                    break;
                   default:
                    Console.WriteLine("Entered Wrong Choice");
                    break;
            }
        }
    }
}
