using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            Regex regex= new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);

            string[] result = matchCollection.Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
