using Godot;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public partial class Card : Resource
{
	[Export] public double multicastScalar = 1;
	[Export] public double multicardScalar = 1;
	[Export] public double potencyScalar = 1;
	[Export] public double castSpeedScalar = 1;
	[Export] public string title = "default";
	public Action cast = () => {
		GD.Print("I'm casting an un-asigned function");
	};
}
