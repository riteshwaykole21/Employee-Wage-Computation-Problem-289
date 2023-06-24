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
            int isfulltime = 1;
            int isparttime = 2; 
            int wageperhrs = 20;
            int empHrs = 0;
            int empwage = 0;
            Random random = new Random();
            int check = random.Next(0,3);
            if(check == isfulltime)
            {
                Console.WriteLine("Employee Is Present Full Time");
                empHrs = 8;
            }
            else if(check == isparttime)
            {
                Console.WriteLine("Employee Is Present Part Time");
                empHrs = 4;
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
