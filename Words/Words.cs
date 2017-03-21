using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Words
{
    public class Words
    {
        public static IEnumerable<string> GetWords()
        {
            using (var sr = new StreamReader("polish.txt"))
            {   
                string line="";
                Thread.Sleep(2000);
                while ((line = sr.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
        
    }
}
