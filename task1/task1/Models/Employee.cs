using System;
using System.Collections.Generic;
using System.Text;

namespace task1.Models
{
    class Employee : Person
    {
        public double SalaryOfHour { get; set; }
        public int WorkingHour { get; set; }
        public Employee()
        {

        }
        public Employee(double SalaryOfHour, int WorkingHour) : base()
        {
            this.SalaryOfHour = SalaryOfHour;
            this.WorkingHour = WorkingHour;
        }
        public string CalculateSalary ()
          {
            try
            {
            if (Age < 18)
            {
                return "islemek ucun huququnuz yoxdu";
            }
            double Generalsalary = SalaryOfHour * WorkingHour;
            string condition = $"ayliq maas: {Generalsalary}";
            if (Generalsalary<2000)
            {
                condition = "ayliq maas 2000 az olmamalidir";
            }
            if (WorkingHour < 8 || WorkingHour > 22)
            {
                condition = "gunluk ortalama saati 8 saatdan cox olmamalidir";
            }
            return condition;

            }
            catch (NullReferenceException)
            {
                throw new Exception("nnkl");
            }
        }
    }
}


    
