﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geeky.Models
{
    public class GImage:IImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Size { get; set; }
    }
}
