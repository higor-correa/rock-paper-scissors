using System.Collections.Generic;

namespace RockPaperScissors.Bll.Utils
{
    public class FormatWinnerResponse
    {
        public static string Format(List<string> player)
        {
            return string.Format("[\"{0}\", \"{1}\"]", player[0], player[1]);
        }
    }
}
