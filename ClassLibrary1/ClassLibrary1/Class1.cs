using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public abstract class Car
    {
        protected int curSpeed;
        protected int maxSpeed;
        protected int CurSpeed { set { if (value <= maxSpeed) curSpeed = value; } get { return curSpeed; } }
        protected int MaxSpeed { get { return maxSpeed; } }
        protected Car(int curSpeed, int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
            this.CurSpeed = curSpeed;
        }
        abstract public void Up();
        abstract public void Down();
    }
}