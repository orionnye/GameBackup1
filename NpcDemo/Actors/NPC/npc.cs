using Godot;
using System;

public partial class npc : StaticBody3D {
	private bool hasTarget = false;
	[Export] public Control Dialogue;
	[Export] public PackedScene gift;
	public bool focused = false;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		// Dialogue = GetNode<Control>("Dialogue");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}
	
	private void _on_area_3d_body_entered(Node3D body) {
		if (body.GetType() == typeof(Controlled)) {
			GD.Print("Hello Controller!");
			Dialogue.Visible = true;
			focused = true;
		}
	}

	private void _on_area_3d_body_exited(Node3D body) {
		if (body.GetType() == typeof(Controlled)) {
			GD.Print("Goodbye Controller!");
			focused = false;
			Dialogue.Visible = false;
		}
	}

	private void _on_button_pressed() {
		GD.Print("Spawning Sphere!");
		// Replace with function body
		Node3D instance = (Node3D)gift.Instantiate();
		GetTree().Root.AddChild(instance);
		instance.GlobalPosition = GlobalPosition + new Vector3(0, 3, 0);
	}
	private void _on_cube_button_pressed() {
		// Replace with function body.
	}
}


