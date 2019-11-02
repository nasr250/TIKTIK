using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

public class Bomb : GameObject
{
    Texture2D ball;
    Vector2 Bombposition, Bombvelocity;
    bool shooting;
    

    public Bomb(ContentManager Content)
    {
        ball = Content.Load<Texture2D>("Ball");
        Player player = GameWorld.Find("player") as Player;
        Bombposition = player.GlobalPosition;
        Bombvelocity = Vector2.Zero;
        shooting = false;
    }

    public override void HandleInput(InputHelper inputHelper)
    {
        if (inputHelper.KeyPressed(Keys.X) && !shooting)
        {
            shooting = true;
            velocity.X = 600;
        }
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
        spriteBatch.Draw(ball, Bombposition, Color.White);
    }
}

