using Godot;
using System;

public partial class FocusFinder : Camera3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		// Explore Method to Notify/Ping Groups
		// Ping camera on seeing player?

		// Place holder code for now, should suffice
		Godot.Collections.Array<Godot.Node> shopKeeps = GetTree().GetNodesInGroup("NPC");
		foreach (npc shopKeep in shopKeeps) {
			if (shopKeep.focused) {
				// var dialogue = shopKeep.GetNode("Dialogue");
				// AddChild(dialogue);
				// GD.Print("I seeee you!!!");
			}
		}
	}
}
