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
            int present = 1;
            int wageperhrs = 20;
            int empHrs = 0;
            int empwage = 0;
            Random random = new Random();
            int check = random.Next(2);
            if (check == present)
            {
                Console.WriteLine("Employee Is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
                empHrs = 0;
            }
            empwage = wageperhrs * empHrs;
            Console.WriteLine(empwage);
        }
    }
}
