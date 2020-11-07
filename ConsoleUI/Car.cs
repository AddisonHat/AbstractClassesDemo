using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public Car()
        {

        }

        public bool HasSideCart { get; set; } = false;
        public bool HasTrunk {get; set;} = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive");
        }

    }
}
