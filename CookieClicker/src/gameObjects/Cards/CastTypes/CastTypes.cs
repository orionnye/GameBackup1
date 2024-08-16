using Godot;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public partial class CastTypes : Resource
{
	public Dictionary<string, Card> library = new Dictionary<string, Card>();

	public void Ready() {
		Card punch = new Card();
		punch.castSpeedScalar = 2;
		punch.cast = () => {
			GD.Print("I'm punching, go fuck yourself");
		};
		Card mend = new Card();
		mend.castSpeedScalar = 0.5;
		mend.cast = () => {
			GD.Print("I'm mending, I'll fuck myself");
		};
		library.Add("punch", punch);
		library.Add("mend", mend);
	}
}
