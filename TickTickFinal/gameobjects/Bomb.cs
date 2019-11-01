using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bomb : AnimatedGameObject
{
    public Bomb()
    {
        Player player = GameWorld.Find("player") as Player;
        position = player.Position;
        velocity = Vector2.Zero;
    }

    public override void HandleInput(InputHelper inputHelper)
    {
        if (inputHelper.KeyPressed(Keys.X))
        {           
            visible = true;
        }
    }

    public override void Reset()
    {
        visible = false;
    }
}

