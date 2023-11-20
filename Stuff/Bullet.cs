using Godot;
using System;

public partial class Bullet : Node3D
{
	public const float speed = 5.0f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AddToGroup("Bullets");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
	
	private void _on_area_3d_body_entered(Node3D body)
	{
	if (body != null && body.IsInGroup("Player"))
		{
			CallDeferred("free");
		}
}
}




