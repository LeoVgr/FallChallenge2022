
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
public enum UnitStatus
{
    UNKNOWN = 0,
    WAITING,
    MOVING,
}

public class Unit
{
    public int X, Y;
    public UnitStatus Status;

    public Unit(int x, int y)
    {
        this.X = x;
        this.Y = y;
        Status = UnitStatus.WAITING;
    }

    public void Move(ref List<String> actions, int x, int y)
    {
        actions.Add(String.Format($"MOVE {1} {this.X} {this.Y} {x} {y}"));

        this.X = x;
        this.Y = y;
    }
}