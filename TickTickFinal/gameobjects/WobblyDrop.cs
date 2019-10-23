using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WobblyDrop : WaterDrop
{
    public override void MoveDrop()
    {
        position.X -= velocity;
        if (counter == 10)
        {
            velocity *= -1;
            counter = 0;
        }
    }
}
