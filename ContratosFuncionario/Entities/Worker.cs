using System.Collections.Generic;
using ContratosFuncionario.Entities.Enums;
 
namespace ContratosFuncionario.Entities
{
    class Worker
    {
       public string Name { get; set; } 
       public WorkerLevel Level { get; set; }
       public double BaseSalary  { get; set; }

        public Department Deparmaent { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department deparmaent)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Deparmaent = deparmaent;
        }

        public void AddContract(HourContract Contract)
        {
            Contracts.Add(Contract);
        }

        public void RemoveContract(HourContract Contract)
        {
            Contracts.Remove(Contract);
        }

        public double income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract Contract in Contracts)
            {
                if (Contract.Date.Year == year && Contract.Date.Month == month)
                {
                    sum += Contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
