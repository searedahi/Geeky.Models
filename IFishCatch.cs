using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geeky.Models
{
    public interface IFishCatch
    {
        IFish Fish { get; set; }
        int FishCaught { get; set; }

    }
}
