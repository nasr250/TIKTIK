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
        position = player.Position + new Vector2(-GameEnvironment.Screen.X / 2, -GameEnvironment.Screen.Y / 2);
        if (position.X < 0)
            position.X = 0;
        if (position.X > tile.Columns * tile.CellWidth - GameEnvironment.Screen.X)
            position.X = tile.Columns * tile.CellWidth - GameEnvironment.Screen.X;
        if (position.Y > tile.Rows * tile.CellHeight - GameEnvironment.Screen.Y)
            position.Y = tile.Rows * tile.CellHeight - GameEnvironment.Screen.Y;
    }
}

