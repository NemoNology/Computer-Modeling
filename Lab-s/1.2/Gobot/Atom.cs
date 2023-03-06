using Godot;
using System;

public partial class Atom : RigidBody2D
{
	private Random rnd = new Random(DateTime.Now.Millisecond);
	private Vector2 _movement;
	private int _maxSpeed = 350;
	private CollisionShape2D test;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_movement = new Vector2(
			rnd.NextSingle() * rnd.NextInt64(0, _maxSpeed) * rnd.Next(-1,1),
			rnd.NextSingle() * rnd.NextInt64(0, _maxSpeed) * rnd.Next(-1,1));
	}

	
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position += _movement * (float)delta;
	}
	
	private void _on_body_entered(Node body)
	{
		_movement = _movement.Bounce(body.GetChild<RigidBody2D>(0).Transform.Origin.Normalized());
	}
	
}


	
