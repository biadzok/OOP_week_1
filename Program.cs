using System;
using System.Collections.Generic;
using Parking_problem.Models;

namespace Parking_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Car car1 = new Car("my_first_car", 0);
            cars.Add(car1);

            Addtime(cars, 10);


            Car car2 = new Car("an_other_car", 0);
            cars.Add(car2);

            Addtime(cars, 1);

            car2.CalculateCharge();
            cars.Remove(car2);

            
            Car car3 = new Car("that_one", 0);
            cars.Add(car3);

            Addtime(cars, 4);
            
            Car car4 = new Car("this_one", 0);
            cars.Add(car4);

            Addtime(cars, 6);

            car3.CalculateCharge();
            cars.Remove(car3);

            car4.CalculateCharge();
            cars.Remove(car4);

            Car car5 = new Car("that_other_one", 0);
            cars.Add(car5);

            Addtime(cars, 7);

            car1.CalculateCharge();
            cars.Remove(car1);

            car5.CalculateCharge();
            cars.Remove(car5);
        }
        static void Addtime(List<Car> cars, int time)
        {
            foreach (Car car in cars)
            {
                car.parkedtime += time;
                if (car.parkedtime > 24)
                    car.parkedtime = 24;
            }
        }
    }
}
