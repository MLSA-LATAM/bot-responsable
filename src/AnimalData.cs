using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalHelp
{
    public class AnimalData
    {
        protected Animal[] Animals { get; set; }

        public AnimalData(string fn)
        {
            var data = System.IO.File.ReadAllLines(fn);
            Animals = (from z in data.Skip(1)
                         select new Animal(z)).ToArray();
        }

        public string GetAnimal(string animal)
        {
            return Animals.FirstOrDefault(
                c => c.Spanish.ToLower() == animal.ToLower())?.English;
        }
    }

    public class Animal{
        public Animal(string s)
        {
            var t = s.Split(',');
            English = t[0].Trim('"');
            Spanish = t[1].Trim('"');
        }
        public string English { get; set; }
        public string Spanish { get; set; }
    }
}
