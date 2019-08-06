using System; 
using System.Text;
using EntitiesEnums.Entities;
using EntitiesEnums.Entities.Enums;
namespace EntitiesEnums
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Type (Ore, Wood, Fiber, Leather, Stone)");
            TypeResource type = Enum.Parse<TypeResource>(Console.ReadLine());

            Console.WriteLine("Estagio da materia (Druto/Refined) :");
            InternshipResource internship = Enum.Parse<InternshipResource>(Console.ReadLine());

            Console.WriteLine("Tier (Tier1/.../Tier8) :");
            TierResource tier = Enum.Parse<TierResource>(Console.ReadLine());

            Console.WriteLine("Enchantments  (1,2 e 3) :");
            EnchantmentsResource enchantments = Enum.Parse<EnchantmentsResource>(Console.ReadLine());

            Console.WriteLine("Quantity:");
            int quantity = int.Parse(Console.ReadLine());

            Resource x = new Resource(type, internship, tier, enchantments, quantity);

            Console.WriteLine(x);


        }
    }
}
