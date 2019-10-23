using System;
using Microsoft.Xna.Framework.Design;

class RisingDrop : WaterDrop
{
    public override void MoveDrop()
    {
        if (randomcounter == 0)
        {
            position.Y += 20;
            randomcounter = random.Next(100,200);
        }
    }
}

