using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

public class Camera : GameObject
{
    protected Vector2 camerapos;
    public Matrix transform{ get; private set;}
    public Camera()
    {
        camerapos = new Vector2(55555555555, 50);
    }
    public void Update()
    {
        Player player = GameWorld.Find("player") as Player;
    }
}

