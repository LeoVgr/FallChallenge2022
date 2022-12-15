
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
public class Tile
{
    public int X, Y, ScrapAmount, Owner, Units;
    public bool Recycler, CanBuild, CanSpawn, InRangeOfRecycler;

    public Tile(int x, int y, int scrapAmount, int owner, int units, bool recycler, bool canBuild, bool canSpawn, bool inRangeOfRecycler)
    {
        this.X = x;
        this.Y = y;
        this.ScrapAmount = scrapAmount;
        this.Owner = owner;
        this.Units = units;
        this.Recycler = recycler;
        this.CanBuild = canBuild;
        this.CanSpawn = canSpawn;
        this.InRangeOfRecycler = inRangeOfRecycler;
    }
}