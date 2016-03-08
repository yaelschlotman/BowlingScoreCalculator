using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BowlingCalculator2
{
    public class FileReader
    {
        public List<string> ReadFromFile()
        {
            int i = 0;
            List<string> ListOfStrings = new List<string>();
            using (StreamReader streamReader = new StreamReader(@"../../BowlingPlayer.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    ListOfStrings.Add(streamReader.ReadLine());

                    i++;
                }
            }
            foreach (string item in ListOfStrings)
            {
                Console.WriteLine(item);
            }
            return ListOfStrings;
        }
    }
}
