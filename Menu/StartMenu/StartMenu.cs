using Godot;
using System;

public partial class StartMenu : Control
{
	public void StartBtnPressed(){
		GetTree().ChangeSceneToFile("res://PlayTest/Egg/Egg.tscn");
	}
}
