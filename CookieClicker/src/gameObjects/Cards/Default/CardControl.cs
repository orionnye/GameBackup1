using Godot;
using System;

public partial class CardControl : Node3D
{
	public MeshInstance3D mesh;
	[Export]
	public double lerpRate = 0.1;
	private double maxTimeout = 2;
	private double timeout = 0;
	public bool is_spinning() {
		return Rotation != mesh.Rotation;
	}
	public bool is_faceUp() {
		return Rotation.Y == 0;
	}
	public void flip180() {
		float flip = (float)Math.PI/2;
		if (is_faceUp()) {
			RotateY(flip);
			mesh.RotateY(-flip/2);
		} else {
			RotateY(-flip);
			mesh.RotateY(flip/2);
		}
	}
	public void correctRotation() {
		Vector3 rotDiff = Rotation - mesh.Rotation;
		Vector3 lerped = rotDiff*(float)lerpRate;
		mesh.RotateY(lerped.Y);
	}
	public void correctPosition() {
		Vector3 lerped = mesh.Position*(float)0.05;
		mesh.Translate(-lerped);
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		mesh = GetNode<MeshInstance3D>("MeshInstance3D");
		base._Ready();

		// GD.Print("Monkey Ready");
		// flip180();
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// GD.Print("Terrible terrible correction");
		if (timeout < maxTimeout) {
			timeout += delta;
		} else {
			timeout = 0;
			// GD.Print("Monkey");
			// flip180();
			// GD.Print(RotationDegrees.Y);
		}
		if (!is_faceUp()) {
			mesh.Position = new Vector3(0, 0, 0);
		}
		// if (is_spinning()) {
		// }
		correctRotation();
		correctPosition();
	}
}
