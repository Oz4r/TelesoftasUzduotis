using System.Collections.Generic;

namespace TelesoftasUzduotis
{
    public static class Truncation
    {
        public static List<string> Truncate(this string myString, int maxLength, List<string> lines)
        {
            while (myString.Length > 0)
            {
                if (myString.Length <= maxLength)
                {
                    lines.Add(myString);
                    break;
                }
                //CHANGE THIS
                var indexOfLastSpace = myString.Substring(0, maxLength).LastIndexOf(' ');
                lines.Add(myString.Substring(0, indexOfLastSpace >= 0 ? indexOfLastSpace : maxLength).Trim());
                myString = myString.Substring(indexOfLastSpace >= 0 ? indexOfLastSpace + 1 : maxLength);
            }
            return lines;
        }
    }
}
