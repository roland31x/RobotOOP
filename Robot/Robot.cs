using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot
{
    public abstract class Robot
    {
        public bool IsRunning { get; set; }
        public abstract Planets TargetPlanet { get; protected set; }
        public abstract void DoWork(Planets target);
    }
    public class GiantKillerRobot : Robot
    {
        public Intensity LaserEyeIntensity { get; private set; }
        public Lifeform CurrentTarget { get; private set; }
        public override Planets TargetPlanet { get; protected set; }

        public GiantKillerRobot()
        {
            IsRunning = false;
            LaserEyeIntensity = Intensity.InstantKill;
        }
        public override void DoWork(Planets t)
        {
            IsRunning = true;
            TargetPlanet = t;
            while(IsRunning && TargetPlanet.ContainsLife)
            {
                if (CurrentTarget == null || !CurrentTarget.IsAlive)
                {
                    AquireNextTarget();
                }
                else
                {
                    FireLaserAt(CurrentTarget);
                }
                Thread.Sleep(50);
            }
            Console.WriteLine(TargetPlanet.ToString() + " is out of living inhabitants.");
            Console.WriteLine(this.ToString() + " shuts down.");
        }
        void AquireNextTarget()
        {
            foreach(var target in TargetPlanet.Inhabitants) 
            {
                if (target.IsAlive)
                {
                    CurrentTarget = target;
                    Console.WriteLine(this.ToString() + " targets " + target.ToString());
                    break;
                }
            }
            if(!CurrentTarget.IsAlive || CurrentTarget == null)
            {
                this.IsRunning = false;               
            }
        }
        void FireLaserAt(Lifeform target)
        {
            target.HP -= LaserEyeIntensity.Damage;
            if (target.IsAlive)
            {
                Console.WriteLine(this.ToString() + " damages " + target.ToString() + " with " + LaserEyeIntensity.Damage.ToString() + " damage." + " Remaining HP: " + target.HP.ToString());
            }
            else
            {
                Console.WriteLine(this.ToString() + " destroys " + target.ToString());
            }
            
        }
        public override string ToString()
        {
            return "GiantKillerRobot";
        }
    }
}
