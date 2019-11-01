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
        TileField tile = GameWorld.Find("tiles") as TileField;
        Player player = GameWorld.Find("player") as Player;
        if (player.Position.X > GameEnvironment.Screen.X / 2 && player.Position.X < tile.Columns * tile.CellWidth - GameEnvironment.Screen.X/2)
            position.X = player.Position.X - GameEnvironment.Screen.X / 2;
        if (player.Position.Y < GameEnvironment.Screen.Y / 2)
          position.Y = player.Position.Y - GameEnvironment.Screen.Y / 2;
    }
    public void Reset()
    {
        position = Vector2.Zero;
    }
}

