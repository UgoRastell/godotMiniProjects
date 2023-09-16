using Godot;
using System;

public partial class PhysicsPlayer : RigidBody2D
{
	public float hitForce = 50.0f;
	public dir = globalPostion 

	public override void _Ready()
	{
	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        if (Input.IsMouseButtonPressed(MouseButton.Left))
        {
			GD.Print("test");
        }
    }
}
