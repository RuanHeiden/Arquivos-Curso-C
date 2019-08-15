using System;
using System.Collections.Generic;
using System.Text;

namespace objetoCompartilhado.Entities
{
    class Newsletter
    {
        public string Preference { get; set; }
        public string DayWeek { get; set; }


        public Newsletter()
        {
        }

        public Newsletter(string preference, string dayWeek)
        {
            Preference = preference;
            DayWeek = dayWeek;
        }

        public String ValueNewsletter()
        {
            return "Na "+ DayWeek+",ira receber o newsLetter da preferencia de produtos "+ Preference +".";
        }

    }
}
