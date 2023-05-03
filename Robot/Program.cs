using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new GiantKillerRobot();
            for(int i = 0; i < 20; i++)
            {
                List<Lifeform> list = new List<Lifeform>();
                if(i % 10 == 0)
                {
                    list.Add(new SuperHero(Planets.Earth));
                }
                else if(i % 2 == 0)
                {
                    list.Add(new Animal(Planets.Earth));
                }
                else
                {
                    list.Add(new Human(Planets.Earth));
                }
            }
            robot.DoWork(Planets.Earth);
        }
    }
}
