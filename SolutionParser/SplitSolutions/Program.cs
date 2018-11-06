using RegExtensions;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SplitSolutions
{
    class Program
    {
        /// <summary>
        /// Languages pared with their file extension
        /// </summary>
        private static Dictionary<string, string> fileExtensions = new Dictionary<string, string>()
        {
            { "C#", ".cs" },
            { "JavaScript", ".js" },
            { "Python", ".py" },
            { "C", ".c" },
            { "C++", ".cpp" },
            { "Clojure", ".clj" },
            { "Elixir", ".ex" },
            { "Java", ".java" },
            { "PHP", ".php" },
            { "Lua", ".lua" },
            { "TypeScript", ".ts" },
            { "Go", ".go" },
            { "Haskell", ".hs" },
            { "R", ".r" },
            { "Ruby", ".rb" },
            { "CoffeeScript", ".coffee" },
            { "Shell", ".sh" },
            { "PowerShell", ".ps" },
            { "F#", ".fs" }
        };

        private static void Main(string[] args)
        {
            // our huge string of solutions to be parsed
            string solutionsFile = File.ReadAllText("solutions.txt");

            // a directory to hold our solution files
            var rootDirectory = new DirectoryInfo("Solutions");

            // create it if it doesn't exist yet
            if (!rootDirectory.Exists)
            {
                rootDirectory.Create();
            }

            // split our solution file into individual solutions
            // based on the string that happens to be at the end of each one
            var solutions = solutionsFile.RegexSplit(@"agoRefactorDiscuss");

            for (int x = 0; x < solutions.Length; x++)
            {
                var lines = solutions[x].Trim().RegexSplit("\r\n");

                // ex: 8 kyu
                string kyu = lines[0];

                // this would indicate another solution for the last kata
                if (!kyu.Contains("kyu"))
                {
                    continue;
                }

                // name of the challenge
                string kataName = lines[1];

                // language (minus the colon at the end)
                string language = lines[2].Substring(0, lines[2].Length - 1);

                // get the directory for this language, ex: Solutions/C#
                var directory = new DirectoryInfo(Path.Combine(rootDirectory.FullName, language));

                // create it if it doesn't exist yet
                if (!directory.Exists)
                {
                    directory.Create();
                }

                // grab the code from the solution (should start on the 4th line, go until the second to last line)
                string code = string.Join("\r\n", lines.Skip(4).Take(lines.Length - 5));

                // ex: Fizz Buzz(8 kyu).cs
                string fileName = kataName + "(" + kyu + ")" + fileExtensions[language];

                // remove all illegal characters
                fileName = fileName.RegexReplace(@"[/\\?%*:|<>]", "").Replace('"', '\'');

                // save the file inside the directory
                File.WriteAllText(Path.Combine(directory.FullName, fileName), code);
            }
        }
    }
}
