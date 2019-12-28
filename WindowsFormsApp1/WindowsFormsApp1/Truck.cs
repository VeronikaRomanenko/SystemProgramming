using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Truck : CarLibrary.Car
    {
        private int cargo;
        private int maxCargo;
        public int Cargo { set { if (value <= maxCargo) cargo = value; } get { return cargo; } }
        public int MaxCargo { get { return maxCargo; } }
        public Truck(int curSpeed, int maxSpeed, int cargo, int maxCargo) : base(curSpeed, maxSpeed)
        {
            this.maxCargo = maxCargo;
            this.Cargo = cargo;
        }

        public override void Down()
        {
            Cargo = 0;
        }

        public override void Up()
        {
            Cargo += 100;
        }
    }
}