using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        //Below is the constructor
        public Bird()
        {
            IsAlive = true;
            Age = 69;
            LegCount = 2;
            LandSeaAir = "Air";
        }

        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public bool WillMigrate { get; set; }
        public double BeakLength { get; set; }

    }
}