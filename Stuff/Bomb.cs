using Godot;
using System;

public partial class Bomb : Area3D
{
	
	float health = 4;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (health <= 0)
		{
			GD.Print("dead");
			GetTree().ReloadCurrentScene();
		}
		
	}
	
	void _on_body_entered(Node3D body)
	{	
		
		if (body != null && body.IsInGroup("Bullets"))
		{
			health -= 1;
			GD.Print(health);
			body.QueueFree();
		}
	}
}






