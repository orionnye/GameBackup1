using Godot;
using Godot.Collections;
using Array = Godot.Collections.Array;
using System;
using System.Linq;
using System.Data;

public partial class Deck : Node3D
{
	[Export] public Vector3 offset = new Vector3(0.1f, -0.1f, 0.2f);
	[Export] public Vector3 selectPos = new Vector3(5, 6, 0);
	public PackedScene card = GD.Load<PackedScene>("res://src/gameObjects/Cards/Default/card.tscn");

	private double maxTimeout = 2;
	private double timeout = 0;

	public void spawnCards(int cardCount = 10) {
		for (var i = 0; i < cardCount; i++) {
			Node3D newCard = card.Instantiate<Node3D>();
			newCard.Translate(offset*i);
			this.AddChild(newCard);
			newCard._EnterTree();
			newCard._Ready();
		}
	}
	public void cleanCardPos() {
		Godot.Collections.Array<Godot.Node> children = GetChildren();
		for (int i = 0; i < children.Count; i++)
		{
			Vector3 desiredPos = offset*i;
			// Vector3 posDiff = children[i].pos
			// children[i].
		}
	}
	public void shuffle(int shuffleCount = 1) {
		// Shuffles all children
	}
	public void flipTopCard() {
		CardControl child = GetChild<CardControl>(2);
		child.flip180();
	}
	public void flipCards() {		
		// Array<CardControl> children = new Array<CardControl>();
		foreach (var child in GetChildren())
		{
			CardControl yus = (CardControl)child; 
			if (child is CardControl) {
				// GD.Print("Absolute Fuckery");
				yus.flip180();
			}
		}
	}

	public void selectCard() {
		// CardControl[] children = this.FindChildren("", "CardControl");
		CardControl child = GetChild<CardControl>(0);
		child.mesh.Set("position", new Vector3(4, 0, 0));
	}
	// Function that puts card into the very back of the deck
	public void pushCardToBack() {
		// take the card
		CardControl child = GetChild<CardControl>(0);
		this.RemoveChild(child);
		this.AddChild(child);
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();
		// GD.Print("blah blah blah");
		spawnCards(3);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (timeout < maxTimeout) {
			timeout += delta;
		} else {
			Godot.Collections.Array<Godot.Node> children = GetChildren();
			timeout = 0;
			selectCard();
			flipCards();
			// GD.Print("Gaboogah");
			// GD.Print("CardTotal: ", children.Count());
			// flipTopCard();
			// GD.Print(RotationDegrees.Y);
		}
		// Godot.Collections.Array<Godot.Node> children = GetChildren();
		// GD.Print("childrenCount: ", children.Count);
	}
}
