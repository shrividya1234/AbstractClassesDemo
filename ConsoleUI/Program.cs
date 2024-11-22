using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            

            // Create a list of Vehicle called vehicles
          
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var car1 = new Car() { Year = "2024", 
                Model = "Suv", 
                Make = "Ford", 
                HasTrunk = true,
            };

            var motorcycle1 = new MotorCycle()
            {
                Year = "2024",
                Model = "Camry",
                Make = "Toyota",
                HasSideCart = true
            };
            Vehicle carTwo = new Car() 
            { 
                Year = "2026",
                Make = "Toyota ",
                Model = "SVU",
                HasTrunk = false
                
            };
            Vehicle carThree = new Car()
            {
                Year = "2024",
                Make = "Kia ",
                Model = "Forta",
                HasTrunk = true
            };
            
            var vehicles = new List<Vehicle>(){car1, carTwo, carThree, motorcycle1};
            foreach (var ride in vehicles)
            {
                Console.WriteLine($"{ride.Make} {ride.Model} {ride.Year}");
                ride.DriveAbstract();
                ride.DriveVirtual();
            }
            
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
