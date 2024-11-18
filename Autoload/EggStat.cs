using Godot;
using System;

public partial class EggStat : Node
{
	public static EggStat Instance { get; private set; }
	private int _clicked = 0;
	public EggStat()
	{
		clicked = _clicked;
	}
	public int clicked
	{
		get { return _clicked; }
		set { _clicked = value; }
	}
	public override void _Ready()
	{
		Instance = this;
	}
}
