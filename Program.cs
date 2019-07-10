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
                NumberSeats = 230,
                Speed = 0.79
            };

            var airplane2 = new Airplane(10)
            {
                Make = "Airbus",
                Model = "A320",
                NumberSeats = 150,
                Speed = 0.68
            };

            var Hangar = new List<Airplane>()
            {
                airplane1, airplane2
            };

            airplane1.Fly();
            airplane2.Fly(2500);
            // after below line is run, mileage for airplane2 will be added to be 5000
            airplane2.Fly(2500);

        }
    }

    class Airplane
    {
        // private means anywhere in this class, I can modify miles, but can't modify outside class.
        // called a field - fields are private, start with an underscore, are lowercase camelcase
        private int _miles = 0;

        // all below are called properties.
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberSeats { get; set; }
        public double Speed { get; set; }

        // CONSTRUCTORS
        public Airplane(int startingMiles)
        {
            _miles = startingMiles;
        }

        public Airplane()
        {

        }

        // METHODS
        public void Fly()
        {
            Console.WriteLine($"The {Make} {Model} has {NumberSeats} seats and flys at Mach {Speed}.");
        }

        // Overloading with a field "milesDriven"
        public void Fly(int milesDriven)
        {
            _miles += milesDriven;
            Console.WriteLine($"The {Make} {Model} has {NumberSeats} seats and flys at Mach {Speed}. This one has now flown {_miles} miles");
        }
    }
}

// make model # of seats