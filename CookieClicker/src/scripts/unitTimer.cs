using Godot;
using System;
using System.Numerics;

public partial class unitTimer : Timer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Unit parent = GetParent<Unit>();
		this.Start(parent.dexterity);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		ColorRect bar = GetNode<ColorRect>("../StaminaBar");
		int fullBarX = 128;
		float progress = Convert.ToSingle(this.TimeLeft / this.WaitTime);
		bar.Size = new Godot.Vector2(fullBarX*progress, 30);
	}
	public void _on_timeout()
	{
		// Replace with function body.
		Unit parent = GetParent<Unit>();
		parent.attack(parent.target);
		GD.Print("Unit AutoTurn!");
	}
}


