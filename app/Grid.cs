
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
public class Stage
{
    public int Width, Height;
    public int TurnCount = 1;
    public List<Unit> MyUnits = new List<Unit>();
    public List<Tile> Tiles = new List<Tile>();
    public List<Tile> MyTiles = new List<Tile>();
    public List<Tile> OppTiles = new List<Tile>();
    public List<Tile> NeutralTiles = new List<Tile>();
    public List<Tile> OppUnits = new List<Tile>();
    public List<Tile> MyRecyclers = new List<Tile>();
    public List<Tile> OppRecyclers = new List<Tile>();

    public void InitializedStageState()
    {
        var inputs = Console.ReadLine().Split(' ');
        this.Width = int.Parse(inputs[0]);
        this.Height = int.Parse(inputs[1]);
    }

    public void UpdateStageState()
    {
        // ! Keep track of turn count, this might be usefull for planing some strategy
        this.TurnCount++;

        var inputs = Console.ReadLine().Split(' ');
        int myMatter = int.Parse(inputs[0]);
        int oppMatter = int.Parse(inputs[1]);

        for (int y = 0; y < this.Height; y++)
        {
            for (int x = 0; x < this.Width; x++)
            {
                inputs = Console.ReadLine().Split(' ');
                int scrapAmount = int.Parse(inputs[0]);
                int owner = int.Parse(inputs[1]); // 1 = me, 0 = foe, -1 = neutral
                int units = int.Parse(inputs[2]);
                int recycler = int.Parse(inputs[3]);
                int canBuild = int.Parse(inputs[4]);
                int canSpawn = int.Parse(inputs[5]);
                int inRangeOfRecycler = int.Parse(inputs[6]);

                Tile tile = new Tile(
                        x,
                        y,
                        scrapAmount,
                        owner,
                        units,
                        recycler == 1,
                        canBuild == 1,
                        canSpawn == 1,
                        inRangeOfRecycler == 1);

                Tiles.Add(tile);

                if (tile.Owner == Player.ME)
                {
                    MyTiles.Add(tile);

                    if (this.TurnCount == 0 && tile.Units > 0)
                    {
                        this.MyUnits.Add(new Unit(tile.X, tile.Y));
                    }

                    else if (tile.Recycler)
                    {
                        MyRecyclers.Add(tile);
                    }
                }
                else if (tile.Owner == Player.OPP)
                {
                    OppTiles.Add(tile);
                    if (tile.Units > 0)
                    {
                        OppUnits.Add(tile);
                    }
                    else if (tile.Recycler)
                    {
                        OppRecyclers.Add(tile);
                    }
                }
                else
                {
                    NeutralTiles.Add(tile);
                }
            }
        }
    }