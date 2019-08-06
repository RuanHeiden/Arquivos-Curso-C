using System;
using System.Text;
using System.Collections.Generic;
using EntitiesEnums.Entities.Enums;


namespace EntitiesEnums.Entities
{
    class Resource
    {
        public TypeResource Types { get; set; } // tipo do recursos (minerio, madeira...)
        public InternshipResource Internships { get; set; } // refinado ou não refinado
        public TierResource Tiers { get; set; }// t1,t2,3,t4,t5 ...
        public EnchantmentsResource Enchantments { get; set; }// Encamtamento t1.2, t2.2, t2.3 ...
        public int QuantityResource { get; set; }// Quantidade de recursos

        public Resource()
        {
        }

        public Resource(TypeResource types, InternshipResource internships, TierResource tiers, EnchantmentsResource enchantments, int quantityResource)
        {
            Types = types;
            Internships = internships;
            Tiers = tiers;
            Enchantments = enchantments;
            QuantityResource = quantityResource;
        }

        public override string ToString()
        {
            return Types + ", "+
                   Internships +", "+
                   Tiers + ", "+
                   Enchantments +", " +
                   QuantityResource ;

        }
    }
}
