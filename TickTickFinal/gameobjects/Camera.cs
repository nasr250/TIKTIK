using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


public class Camera : GameObject
{
    public Camera()
    {
        position = new Vector2(0,0);
    }
    public void Update()
    {
        Player player = GameWorld.Find("player") as Player;
        position = player.Position;
    }
}

