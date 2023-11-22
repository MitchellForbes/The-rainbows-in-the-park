using Godot;
using System;

public partial class Bullet : CharacterBody3D
{
	[Export]
	public int minSpeed { get; set; } = 5;
	[Export]
	public int maxSpeed { get; set; } = 10;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AddToGroup("Bullets");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		MoveAndSlide();
	}
	
	private void _on_area_3d_body_entered(Node3D body)
	{
			QueueFree();
	}
	
	public void Initialize(Vector3 startPosition, Vector3 playerPosition)
	{
		LookAtFromPosition(startPosition, playerPosition, Vector3.Up);
		GD.Print("Spawned");
		int randomSpeed = GD.RandRange(minSpeed, maxSpeed);
		
		Velocity = Vector3.Forward * randomSpeed;
		
		Velocity = Velocity.Rotated(Vector3.Up, Rotation.Y);
	}
}


