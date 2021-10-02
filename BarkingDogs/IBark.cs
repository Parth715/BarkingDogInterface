using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    interface IBark
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string BarkSound { get; set; }

        string Bark();
    }
   
}
