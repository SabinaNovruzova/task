using System;
using task1.Models;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Employee emp = new Employee();
            Student st = new Student();
        Start:
            try
            {
                Console.WriteLine("iscinin adin daxil edin:");
                emp.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("iscinin soyadin daxil edin:");
                emp.Surname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("------------------------------");
                Console.WriteLine("iscinin yasin daxil edin:");
                emp.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------");
                Console.WriteLine("saatbasi qazandigi maasi daxil edin:");
                emp.SalaryOfHour = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("-------------------------");
                Console.WriteLine("30 gunde nece saat islediyini daxil edin:");
                emp.WorkingHour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------");
                Console.WriteLine($"isci:{emp.Name} {emp.Surname}");
                Console.WriteLine($"umumi maas:{emp.CalculateSalary()}");

                Console.WriteLine("----------------------------------");

                Console.WriteLine("telebenin adin daxil edin:");
                st.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("-----------------------");
                Console.WriteLine("telebenin soyadin daxil edin:");
                st.Surname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("-------------------------");
                Console.WriteLine("telebenin yasin daxil edin:");
                st.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------");
                Console.WriteLine("IQ imtahaninin neticesin daxil edin:");
                st.IQRank = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------");
                Console.WriteLine("dil imtahaninin neticesin daxil edin:");
                st.LanguageRank = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------");
                Console.WriteLine($"telebe:{st.Name} {st.Surname}");
                Console.WriteLine($"imtahan neticeniz:{st.ExamResult()}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("sagolun");
            }

        }
    }
}
