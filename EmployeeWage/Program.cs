using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation");
            Attendances attendances = new Attendances();
            attendances.Check();
            Console.ReadLine();
        }
    }
}
