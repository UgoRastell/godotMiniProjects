using Godot;
using System;

public partial class Ballon : Area3D
{

	[Export] public int clicksToPop = 3;

	public float sizeIncrease = 0.2f;
	public int scoreToGive = 1;
	public Vector3 scale;
	private BallonManager ballonManager;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ballonManager = GetNode<BallonManager>("/root/Main");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_input_event(Node camera, InputEvent @event, Vector3 position, Vector3 normal, long shape_idx)
	{

		if (@event is InputEventMouseButton mouseEvent && mouseEvent.Pressed && mouseEvent.ButtonIndex == MouseButton.Left)
		{
			Scale += Vector3.One * sizeIncrease;
			clicksToPop -= 1;

			if (clicksToPop == 0)
			{
				int newScore = ballonManager.IncreaseScore(scoreToGive);
				GD.Print("Nouveau score : " + newScore);
				QueueFree();
			}

		}
	}
}
