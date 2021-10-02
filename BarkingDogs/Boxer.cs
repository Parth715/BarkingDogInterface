using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    class Boxer : Collie, IBark
    {
        public Boxer()
        {
            BarkSound = "Arf";
            Name = "Parth";
            Color = "Blue";
        }
        
        
    }
}
