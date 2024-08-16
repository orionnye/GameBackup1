using Godot;
using System;

//var textLabel;

public partial class OnClick : TextureButton
{
	private Timer myTimer;
	public int clickCount = 0;
	private RichTextLabel counter;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		counter = GetNode<RichTextLabel>("RichTextLabel");
		GD.Print("Hooyrah");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
	//We've got click Counter functioning
	private void _on_pressed()
	{
		clickCount += 1;
		counter.Text = clickCount.ToString();
		GD.Print("labelText:", counter.Text);
		GD.Print("Pressed: ", clickCount);
	}
}


