using Godot;
using System;

public partial class Egg : Node2D
{
	bool mouseEntered = false;
	public override void _Ready()
	{
	  var eggStat = GD.Load<PackedScene>("res://Interface/EggStatUI/EggStatUI.tscn");
	  var eggStatUI = eggStat.Instantiate();
	  AddChild(eggStatUI);
	}
	
	public void MouseEntered(){
	 mouseEntered = true;
	}
	public void MouseExited(){
	 mouseEntered = false;
	}
	
	public void MouseClicked(InputEvent @event){
	  if (@event.IsActionPressed("LClick") == true && mouseEntered == true)
	  {
		 var label = GetNode<Control>("EggStatUI").GetNode<VBoxContainer>("VBoxContainer").GetNode<HBoxContainer>("HBoxContainer").GetNode<Label>("Label");
		 EggStat.Instance.clicked = EggStat.Instance.clicked + 1;
		 int clicked = EggStat.Instance.clicked;
		 label.Text =  clicked.ToString();
	  }
	}
	
	public override void _Input(InputEvent @event)
	{
		MouseClicked(@event);
	}
}
