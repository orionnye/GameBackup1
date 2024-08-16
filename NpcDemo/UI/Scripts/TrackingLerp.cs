using Godot;
using System;

public partial class TrackingLerp : Node3D
{
	[Export] float lerpWeight = 0.9f;
	[Export] float deadzone = 2f;
	[Export] Node3D target;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		
	}
	public void lerpToTarget() {
		Vector3 difference = target.GlobalPosition - GlobalPosition;
		if (difference.Length() > deadzone) {
			GlobalPosition = GlobalPosition.Lerp(target.GlobalPosition, lerpWeight);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		// Check to see if there is a target that needs to be followed
		if (target != null) {
			lerpToTarget();
		}
	}
}
