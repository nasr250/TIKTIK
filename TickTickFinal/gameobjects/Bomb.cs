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
    protected Vector2 Bombposition;
    public Bomb(Vector2 Bombposition)
    {
        LoadAnimation("Sprites/Rocket/spr_rocket@3", "default", true, 0.2f);
        PlayAnimation("default");
        Player player = GameWorld.Find("player") as Player;
        this.Bombposition = player.GlobalPosition;        
    }

    public override void HandleInput(InputHelper inputHelper)
    {
        if (inputHelper.KeyPressed(Keys.X))
        {           
            visible = true;
            velocity.X = 600;
        }
    }

    public override void Reset()
    {
        visible = false;
        velocity = Vector2.Zero;
    }
}

