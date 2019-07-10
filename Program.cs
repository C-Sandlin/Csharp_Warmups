using System;
using System.Collections.Generic;

namespace warmups
{
    class Program
    {
        static void Main(string[] args)
        {
            var airplane1 = new Airplane()
            {
                Make = "Boeing",
                Model = "737 Max",
                Seats = 230,
                Speed = 0.79
            };

            var airplane2 = new Airplane()
            {
                Make = "Airbus",
                Model = "A320",
                Seats = 150,
                Speed = 0.68
            };

            var Hangar = new List<Airplane>()
            {
                airplane1, airplane2
            };

            airplane1.Fly();
            airplane2.Fly();

        }
    }

    class Airplane
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public double Speed { get; set; }

        public void Fly()
        {
            Console.WriteLine($"The {Make} {Model} has {Seats} seats and flys at Mach {Speed}.");
        }
    }
}

// make model # of seats