using Godot;
using System;

public partial class Unit : Resource
{
	[Export] public int HP {get; set;}
	[Export] public int MP {get; set;}
	[Export] public Mesh mesh {get; set;}
	public Unit() {
		HP = 10;
		MP = 10;
		mesh = new SphereMesh();
	}
}
