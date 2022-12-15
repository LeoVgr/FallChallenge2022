using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

public class Application
{
    public static void Main(string[] args)
    {
        var stage = new Stage();
        stage.InitializedStageState();

        // game loop
        while (true)
        {
            stage.UpdateStageState();

            List<String> actions = new List<String>();

            foreach (var tileToCapture in stage.NeutralTiles)
            {
                foreach (var tile in stage.MyUnits)
                {
                    var target = new Vector2(tileToCapture.X, tileToCapture.Y);
                    if (target != null)
                    {
                        int amount = 1;

                    }
                }
            }

            // Wrap it up and send actions of the turn
            var returnString = string.Empty;
            for (var idx = 0; idx < actions.Count; idx++)
            {
                returnString += $"{actions[idx]};";
            }

            Console.WriteLine(returnString);
        }
    }
}