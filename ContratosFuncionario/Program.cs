using System;
using System.Globalization;
using ContratosFuncionario.Entities;
using ContratosFuncionario.Entities.Enums;

namespace ContratosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Departmant's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Worker date:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How money contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write($"Enter #{i} Contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hour): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hour);
                worker.AddContract(contract);
            }

            Console.WriteLine("");

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string  monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departmant" + worker.Deparmaent.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
