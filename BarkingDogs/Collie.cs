using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    class Collie : IBark
    {
        public string Color { get; set; } = "Golden";
        public string Name { get; set; } = "Lassie";
        public string BarkSound { get; set; } = "Woof";

        public string Bark()
        {
            return BarkSound;
        }
        public string Walk()
        {
            return "Walking the dog";
        }
    }
}
