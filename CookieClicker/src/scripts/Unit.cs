using Godot;
using System;

public partial class Unit : Sprite2D
{
	[Export]
	public int hp = 10;
	[Export]
	public int mp = 10;
	[Export]
	public int potency = 1;
	[Export]
	public int dexterity = 2;
	[Export]
	public Unit target;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Label health = GetNode<Label>("Health");
		health.Text = hp.ToString();
		GD.Print("Health!: ", health.Text);
	}
	public void attack(Unit target) {
		if (target != null) {
			target.hp -= potency;
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Label healthBar = GetNode<Label>("Health");
		healthBar.Text = hp.ToString();
	}
}
