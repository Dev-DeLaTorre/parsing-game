using System.IO;

namespace ParsingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"E:\c#_projects\ParsingGame\ParsingGame\input.txt";
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
            }
        }

    }
}
