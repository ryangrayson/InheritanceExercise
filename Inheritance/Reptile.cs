using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            Age = 10;
            LegCount = 0;
            LandSeaAir = "Land";

        }

        //These are automatic properties
        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanRegenerate { get; set; }

    }
}
