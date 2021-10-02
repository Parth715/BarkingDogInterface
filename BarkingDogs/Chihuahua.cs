using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    class Chihuahua : Collie, IBark
    {
        public Chihuahua()
        {
            BarkSound = "Woof";
            Name = "Max";
            Color = "Red";
        }
        
    }
}
