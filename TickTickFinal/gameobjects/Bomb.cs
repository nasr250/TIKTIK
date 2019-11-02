using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bomb : AnimatedGameObject
{
    Vector2 Bombposition, Bombvelocity;
    bool shooting;

    public Bomb(Vector2 Bombposition)
    {
        LoadAnimation("Sprites/Rocket/spr_rocket@3", "default", true, 0.2f);
        PlayAnimation("default");
        Player player = GameWorld.Find("player") as Player;
        Bombposition = player.GlobalPosition;
        Bombvelocity = Vector2.Zero;
        shooting = false;
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        Player player = GameWorld.Find("player") as Player;
        if (shooting)
        {           
            Bombvelocity.X = 600;
            Bombposition += Bombvelocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
        else
        {
            Bombposition = player.GlobalPosition;
        }
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        base.Draw(gameTime, spriteBatch);
        spriteBatch.Draw(null ,Bombposition, Color.White);
    }

}

