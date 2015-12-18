﻿namespace Geeky.Models.Boating
{
    public interface IFascade
    {
        IGeekyThing Get(int id);
        IGeekyThing Save(IGeekyThing thing);
        IGeekyThing Update(IGeekyThing thing);
        IGeekyThing Delete(int id);
    }
}
