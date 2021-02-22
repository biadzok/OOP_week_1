using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_problem.Models
{
    class Car
    {
        public string name { get; set; }
        public int parkedtime { get; set; }
        public Car(string _name, int _parkedtime)
        {
            name = _name;
            parkedtime = _parkedtime;
        }

        public void CalculateCharge()
        {
            Double payment = 2.0;
            if (parkedtime > 3)
            {
                payment += (Convert.ToDouble(parkedtime) - 3) / 2;
                if (payment > 10)
                    payment = 10;
            }
            Console.WriteLine("the car {0} was {1} hour in the parking, you must pay {2} $ to leave", name, parkedtime, payment);
        }
    }
}
