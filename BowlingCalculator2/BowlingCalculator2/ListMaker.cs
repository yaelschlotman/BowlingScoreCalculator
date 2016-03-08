using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BowlingCalculator2
{
    public class ListMaker
    {
        FileReader fileReader = new FileReader();
       public  List<List<string>> ConvertListLinesToList(List<string>ListToConvert)
        {
            List<List<string>>StringListFromLine
                = new List<List<string>>();

            foreach (string item in ListToConvert)
            {
                StringListFromLine.Add(item.Split(' ').ToList());                
            }
           foreach (List<string> item in StringListFromLine)
           {
               Console.WriteLine();
           }
            return StringListFromLine;
        }

        public List<string> ConvertGameScoreToListOfStrings(string GameTally)
        {
            List<string> ListOfFramesAsStrings = new List<string>();
            ListOfFramesAsStrings = GameTally.Split(' ').ToList();
            foreach (string item in ListOfFramesAsStrings)
            {
                Console.WriteLine(item);
            }
            return ListOfFramesAsStrings;
        }
    }
}
