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
    public static Vector2 Bombposition;
    public static Vector2 Bombvelocity;

    public Bomb(Vector2 Bombposition)
    {
        LoadAnimation("Sprites/Rocket/spr_rocket@3", "default", true, 0.2f);
        PlayAnimation("default");
        Player player = GameWorld.Find("player") as Player;
        Bombposition = player.GlobalPosition;        
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }

}

