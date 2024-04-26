using System.IO;
using System.Text.RegularExpressions;

namespace ParsingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string FilePath = @"E:\c#_projects\ParsingGame\ParsingGame\input.txt";
            string OutputFile = @"E:\c#_projects\ParsingGame\ParsingGame\output.txt";
            string[] SplitLine;

            String[] splitLines = File.ReadAllLines(FilePath);
            foreach (string line in splitLines)
            {
                if (line.Contains("split"))
                {
                    SplitLine = line.Split();

                    using (StreamWriter writer = new StreamWriter(OutputFile, true))
                    {
                        writer.Write($"{SplitLine[4]} ");
                    }
                }
            }*/

            string FilePath = @"E:\c#_projects\ParsingGame\ParsingGame\input2.txt";
            string OutputFile = @"E:\c#_projects\ParsingGame\ParsingGame\output2.txt";

            //string pattern = @"\d{3}|\d{2}";
            string pattern = @"\d\d\d?";

            Regex regex = new Regex(pattern);

            string text = File.ReadAllText(FilePath);
            
            MatchCollection matches =  regex.Matches(text);

            foreach (Match match in matches)
            {
                int value = Int32.Parse(match.Value);

                using (StreamWriter writer = new StreamWriter(OutputFile, true))
                {
                    writer.Write($"{(char)value}");
                }
            }
        }

    }
}
