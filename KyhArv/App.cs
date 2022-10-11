using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhArv
{
    public  class App
    {
        public void Run()
        {

            var stefan = new MonthlyEmployee("Stefan", new DateTime(1972, 8, 1), new DateTime(1980, 1, 1), 19000);
            Console.WriteLine($"Lönen blev {stefan.CalculateSalary()}");

            var oliver = new HourlyEmployee("Oliver", new DateTime(1972, 8, 1), new DateTime(2016, 1, 1), 50, 10);
            Console.WriteLine($"Lönen blev {oliver.CalculateSalary()}");


            var listOfEmployees = new List<Employe>();
            listOfEmployees.Add(stefan);
            listOfEmployees.Add(oliver);
            foreach(var employee in listOfEmployees)
            {
                Console.WriteLine($"{employee.CalculateSalary()}");
            }


        }
    }
}
