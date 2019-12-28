using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bus bus;
        Truck truck;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            truck = new Truck(50, 100, 0, 1000);
            bus = new Bus(50, 100, 0, 25);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Task task = new Task(() => bus.Go());
            task.Start();
            task.Wait();
            label2.Text = bus.Passengers.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            truck.Up();
            label4.Text = truck.Cargo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            truck.Down();
            label4.Text = truck.Cargo.ToString();
        }
    }
}