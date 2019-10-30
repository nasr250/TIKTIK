using System;
using Microsoft.Xna.Framework.Design;

class RisingDrop : WaterDrop
{
   
    public override void MoveDrop()
    {
        counter++;
        if (counter == randomcounter)
        {
            position.Y -= 20;
            counter = 0;
            randomcounter = random.Next(100,201);
        }
    }
}

