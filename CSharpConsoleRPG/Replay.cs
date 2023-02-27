using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleRPG
{
    // This will replay what happened during the game to store what happens into an array.
    public class Replay
    {
        

        public Replay() 
        {
            //creating the replay Array.
            int[] replayArray = new int[10];
            replayArray[0] = 1;
            replayArray[1] = 2;
            replayArray[2] = 3;
            replayArray[3] = 4;
            replayArray[4] = 5;
            replayArray[5] = 6;
            replayArray[6] = 7;

            //creating the replay List
            List<int> replayList = new List<int>();
            replayList.Add(1);
            replayList.Add(2);

            Console.WriteLine(replayArray[4]);

            for (int i = 0; i < replayList.Count; i++)
            {
                Console.WriteLine(replayList[i]);
            }
        }
    }
}
