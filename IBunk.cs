using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geeky.Models
{
    public interface IBunk
    {
        int Id { get; set; }
        string  Name { get; set; }
        string Description { get; set; }

    }
}
