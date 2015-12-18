﻿namespace Geeky.Models.Boating
{
    public interface ITripType : IGeekyThing
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int Duration { get; set; }
    }
}
