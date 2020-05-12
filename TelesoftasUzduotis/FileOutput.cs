using System.Collections.Generic;

namespace TelesoftasUzduotis
{
    public class FileOutput
    {
        public void Output (List<string> lines)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(".\\Result.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
