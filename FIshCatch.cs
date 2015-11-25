using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geeky.Models
{
    public class FIshCatch : IFishCatch
    {
        public IFish Fish { get; set; }
        public int FishCaught { get; set; }
    }
}
