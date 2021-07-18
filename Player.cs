using System;
namespace TriviaGameGroup
{
    public class Player
    {
        public string Name;
        public int points = 0;

        public void AddPoints()
        {
            // the ++ automatically increases
            // the integer by 1!
            points++;
        }

        public void SubPoints()
        {
            // likewise, the -- decreases it.
            points--;
        }
    }
}
