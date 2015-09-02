using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputText = "free numerology compatibility sreesh numerology calculator free free numerology report numerology reading free numerology reading";
            Dictionary<string, int> WordFreq = new Dictionary<string, int>();

            Analyze(ref InputText, ref WordFreq);

            string result = null;
            foreach (KeyValuePair<string, int> pair in WordFreq)
            {
                result += pair.Value + " Instances of " + pair.Key + "\r\n";
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Analyze(ref String InputText, ref Dictionary<string, int> WordFreq)
        {
            string[] Words = InputText.Split(' ');

            for (int i = 0; i < Words.Length; i++)
            {
                if (WordFreq.ContainsKey(Words[i]) == false)
                    WordFreq.Add(Words[i], 1);
                else
                {
                    WordFreq[Words[i]]++;
                }
            }
        }

    }
}