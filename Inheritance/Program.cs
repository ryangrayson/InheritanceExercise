using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal---DONE
            // give this class 4 members that all Animals have in common---DONE


            // Create a class Bird---DONE
            // give this class 4 members that are specific to Bird---DONE
            // Set this class to inherit from your Animal Class---DONE

            // Create a class Reptile---DONE
            // give this class 4 members that are specific to Reptile---DONE
            // Set this class to inherit from your Animal Class---DONE

            /*Create an object of your Bird class---DONE
             *  give values to your members using the object of your Bird class---DONE
             *  
             * Creatively display the class member values 
             */

            var myDuck = new Bird();
            myDuck.WingColor = "blue";
            myDuck.CanFly = true;
            myDuck.WillMigrate = true;
            myDuck.BeakLength = 3.5;

            Console.WriteLine();




            

            /*Create an object of your Reptile class---DONE
             *  give values to your members using the object of your Bird class---DONE
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanRegenerate = true
            };



            var myAnimals = new Animal[] { myDuck, lizard };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"LegCount: {animal.LegCount}");
                Console.WriteLine($"Land, Sea or Air: {animal.LandSeaAir}");
                Console.WriteLine("");
            }
            
            









        }
    }
}
