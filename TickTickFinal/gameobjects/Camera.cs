using System;
using Microsoft.Xna.Framework;


public class Camera : GameObject
{
    Point screen;
    public Matrix transform{ get; private set;}
    public Camera()
    {
        screen = GameEnvironment.Screen;
    }
    public void Update()
    {

    }
}

