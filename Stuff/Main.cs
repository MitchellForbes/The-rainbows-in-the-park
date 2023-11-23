using Godot;
using System;

public partial class Main : Node3D
{
	[Export] 
	public PackedScene BulletScene { get; set; }
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_timer_timeout()
	{
		Bullet bullet = BulletScene.Instantiate<Bullet>();
	
		Vector3 playerPosition = GetNode<Bomb>("Bomb").Position;
		var bulletSpawnLocation = GetNode<PathFollow3D>("SpawnPath/SpawnLocation");
		
		bulletSpawnLocation.ProgressRatio = GD.Randf();
		bullet.Initialize(bulletSpawnLocation.Position, playerPosition);
		
		AddChild(bullet);
		
		//bullet._on_area_3d_body_entered += GetNode<Score>("UserInterface/ScoreLabel").OnBulletHit;
	}
}



