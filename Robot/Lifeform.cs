using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public abstract class Lifeform
    {
        public Planets Inhabits { get; set; }
        public bool IsAlive { get; set; }
        double _hp;
        public double HP { get { return _hp; } set { _hp = value; HPCheck(); } }
        void HPCheck()
        {
            if(HP <= 0)
            {
                IsAlive = false;
                Inhabits.Inhabitants.Remove(this);
            }
        }
    }
    public class Animal : Lifeform
    {
        public Animal(Planets p)
        {
            Inhabits = p;
            p.Inhabitants.Add(this);
            IsAlive = true;
            HP = 30;
        }
        public override string ToString()
        {
            return "Animal";
        }
    }
    public class Human : Lifeform
    {
        public Human(Planets p)
        {
            Inhabits = p;
            p.Inhabitants.Add(this);
            IsAlive = true;
            HP = 100;
        }
        public override string ToString()
        {
            return "Human";
        }
    }
    public class SuperHero : Lifeform
    {
        public SuperHero(Planets p)
        {
            Inhabits = p;
            p.Inhabitants.Add(this);
            IsAlive = true;
            HP = 1000;
        }
        public override string ToString()
        {
            return "Superhero";
        }
    }
}
