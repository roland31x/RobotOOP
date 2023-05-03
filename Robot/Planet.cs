using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Planets
    {
        public string Name { get; set; }
        public List<Lifeform> Inhabitants { get; set; }
        public bool ContainsLife 
        { 
            get 
            { 
                if (Inhabitants.Count > 0) 
                    return true; 
                else 
                    return false; 
            } 
        }

        public static Planets Mercury = new Planets("Mercury");
        public static Planets Venus = new Planets("Venus");
        public static Planets Earth = new Planets("Earth");
        public static Planets Mars = new Planets("Mars");
        public static Planets Saturn = new Planets("Saturn");
        public static Planets Jupiter = new Planets("Jupiter");
        public static Planets Uranus = new Planets("Uranus");
        public static Planets Neptune = new Planets("Neptune");
        protected Planets(string name)
        {
            Name = name;
            Inhabitants = new List<Lifeform>();
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
    
}
