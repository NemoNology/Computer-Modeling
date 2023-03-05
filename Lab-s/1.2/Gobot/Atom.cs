using Godot;
using System;

public partial class Atom : RigidBody2D
{
	private Vector2 _movement;
	public float maxSpeed = 30;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Random rnd = new Random();
		
		_movement = new Vector2(
			rnd.NextSingle() * maxSpeed * (rnd.NextSingle() > 0.5 ? 1 : -1),
			rnd.NextSingle() * maxSpeed * (rnd.NextSingle() > 0.5 ? 1 : -1));
	}

	
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
	
	private void _on_body_entered(Node body)
	{
		AddConstantForce(ConstantForce.Bounce(Vector2.Zero));
	}
	
}


	
