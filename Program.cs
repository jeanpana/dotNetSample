using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Demo
{
    class Car
    {
        int Plate;
        string Model;

        public void SetCar(int carno, string model)
        {
            Plate = carno;
            Model = model;
        }
        public String GetCar()
        {
            return Model;
        }

        static void Main(string[] args)
        {
            Car car = new Car();

            car.SetCar(1234, "Honda");

            Console.WriteLine(car.GetCar());
        }
    }
}