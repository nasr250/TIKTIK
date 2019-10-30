using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


public class Camera : GameObject
{
    public Camera()
    {
        id = "camera";
    }
    public override void Update(GameTime gameTime)
    {
        Player player = GameWorld.Find("player") as Player;
        position = player.Position + new Vector2(-500,-600);
    }
}

