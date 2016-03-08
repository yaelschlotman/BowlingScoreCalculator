using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BowlingCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();

            ListMaker listMaker = new ListMaker();
            listMaker.CreateFrameCharListFromGameTally(fileReader.ReadFromFile());
            Frames frames = new Frames();
            frames.ScoreLastFrame(4, 4);
            frames.ScoreLastFrame(10, 10, 10);
            MethodPlayground methodPlayground = new MethodPlayground();
            methodPlayground.ConvertGameScoreToListOfStrings("X X X X X X X X X XXX");
            methodPlayground.ConvertStrikeNotationsToString(
                methodPlayground.ConvertGameScoreToListOfStrings("X 7/ 72 9/ X X X 23 6/ 7/3"));
            Console.ReadKey();
        }
    }
}
