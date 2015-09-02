using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.Collections.Specialized;

namespace WcfService5
{
    public class Service1 : IService1
    {
        public string[] Top10Words(String url)
        {
            string s;
            using (WebClient client = new WebClient())
            {
                s = client.DownloadString(url);
            }
            Dictionary<string, int> WordFreq = new Dictionary<string, int>();
            Dictionary<string, int> top10 = new Dictionary<string, int>();

            Analyze(ref s, ref WordFreq);
            int max = 0;
            String val = "";
            int index = 0;
            int k=0;
            int Flag = 0;
            for (int j = 0; j < 10; j++)
            {
                foreach (KeyValuePair<string, int> pair in WordFreq)
                {
                    k++;
                    if (max < 300)
                        max = 30;
                    if (pair.Value > max)
                    {
                        foreach (KeyValuePair<string, int> pair2 in top10)
                        {
                            if (pair2.Key.Equals(pair.Value))
                                Flag = 1;
                        }
                            if (Flag == 0)
                            {
                                max = pair.Value;
                                val = pair.Key;
                                index = k;
                                top10.Add(val, max);
                            }
                        
                        }
                    
                    Flag = 0;              
                }
            }
            string[] result = new string[2000];
            int i=0;
            foreach (KeyValuePair<string, int> pair in top10)
            {
                result[i]= pair.Value + " Instances of " + pair.Key;
                i++;
                if (i == 9999)
                {
                    break;
                }
            }
            return (result);
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