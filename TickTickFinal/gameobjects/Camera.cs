using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


public class Camera : GameObject
{
    Viewport viewport;
    public Camera()
    {
        id = "camera";
    }
    public override void Update(GameTime gameTime)
    {
        Player player = GameWorld.Find("player") as Player;
        position = player.Position + new Vector2(-GameEnvironment.Screen.X / 2, -GameEnvironment.Screen.Y / 2);
         if (position.X > viewport.Width)
             position.X = viewport.Width;
         if (position.X < viewport.Width)
             position.X = viewport.Width;
         if (position.Y < viewport.Height)
            position.Y = viewport.Height;
         if (position.Y > viewport.Height)
            position.Y = viewport.Height;
            
    }
}

