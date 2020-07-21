using System.Text.RegularExpressions;

namespace RunClub.Helpers
{
    public class RegexService
    {
        public static bool CheckDate(string input)
        {
            Regex dateRegex = new Regex(@"^\d{2}[.]\d{2}[.]\d{2}");
            return dateRegex.IsMatch(input);
        }

        public static bool CheckNum(string input)
        {
            Regex numRegex = new Regex(@"^\s?\d\s?[,]?");
            return numRegex.IsMatch(input);
        }
    }
}
