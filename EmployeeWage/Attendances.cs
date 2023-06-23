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
            Random random = new Random();
            int check = random.Next(2);
            if(check == present)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}
