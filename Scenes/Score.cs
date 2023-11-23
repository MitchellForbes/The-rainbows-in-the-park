using Godot;
using System;

public partial class Score : Label
{
	private int _score = 0;
	public void OnBulletHit()
	{
		_score += 1;
		Text = $"Score: {_score}";
	}
}
