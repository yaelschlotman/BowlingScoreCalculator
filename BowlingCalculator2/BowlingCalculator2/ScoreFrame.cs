using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingCalculator2
{
    public class ScoreFrame
    {        
        public int ScoreFrameNoSpareNoStrike(int Throw1, int Throw2)
        {
            int FrameScore = 0;
                if (Throw1 >= 0 && Throw1 <= 9 && Throw2 >= 0 && Throw1 < (10 - Throw1))
                {
                    FrameScore = Throw1 + Throw2;
                }           
            return FrameScore;
        }

        public int ScoreLastFrameStrikeOrSpare(int Throw1, int Throw2, int Throw3)
        {
            int LastFrameScore = 0;           
                if (Throw1 == 10 || Throw2 == 10 || (Throw1 + Throw2 == 10))
                {
                    LastFrameScore = Throw1 + Throw2 + Throw3;
                }            
            Console.WriteLine(LastFrameScore);
            return LastFrameScore;
        }
    }
}
