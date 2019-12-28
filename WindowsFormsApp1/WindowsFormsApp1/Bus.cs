using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bus : CarLibrary.Car
    {
        private int passengers;
        private int maxPassengers;
        public int Passengers { set { if (value <= maxPassengers) passengers = value; } get { return passengers; } }
        public int MaxPassengers { get { return maxPassengers; } }
        public Bus(int curSpeed, int maxSpeed, int passengers, int maxPassengers) : base(curSpeed, maxSpeed)
        {
            this.maxPassengers = maxPassengers;
            this.Passengers = passengers;
        }

        public void Go()
        {
            passengers = RandomGenerator.Next(0, maxPassengers);
        }

        public override void Up()
        {
            throw new NotImplementedException();
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}