using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingCalculator2
{
    public class MethodPlayground
    {
        public List<string> ConvertGameScoreToListOfStrings(string GameTally)
        {
            string throwScore;
            List<string> ListOfFramesAsStrings = new List<string>();
            ListOfFramesAsStrings = GameTally.Split(' ').ToList();
            foreach (string listItem in ListOfFramesAsStrings)
            {
                Console.WriteLine(listItem);
            }
            return ListOfFramesAsStrings;
        }

        public List<string> ConvertStrikeNotationsToString(List<string> ListToConvert)
        {
            //this doesn't work for last frame
            string throwScore;
            List<string>StrikeConversionList = new List<string>();
            foreach (string item in ListToConvert)
            {
                if (item.ToLower() == "x")
                {
                    throwScore = "10";
                    StrikeConversionList.Add(throwScore);
                }
                else
                {
                    throwScore = item;
                    StrikeConversionList.Add(throwScore);
                }                              
            }
            foreach (string listItem in StrikeConversionList)
            {
                Console.Write(listItem + ", ");
            }
            return StrikeConversionList;
        } 
    }
}
