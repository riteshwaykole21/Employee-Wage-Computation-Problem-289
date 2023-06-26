using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Attendances
    {
        public void Check()
        {
            const int isfulltime = 1;
            const int isparttime = 2; 
            const int wageperhrs = 20;
            const int workingday = 20;
            int empHrs = 0;
            int empwage = 0;
            for(int i = 1;i <= workingday;i++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case isfulltime:
                        Console.WriteLine("Employee Present Full Time");
                        empHrs = 8;
                        break;
                    case isparttime:
                        Console.WriteLine("Employee Present Part Time");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee Is Absent");
                        break;
                }
                empwage += wageperhrs * empHrs;
            }
            Console.WriteLine("Total Employee Wage " + empwage);
        }
    }
}
