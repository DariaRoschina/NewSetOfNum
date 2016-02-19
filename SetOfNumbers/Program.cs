using System;
using System.Collections.Generic;


namespace SetOfNumbers
{

    class Program
    {
        public static int mex(List<int> lists2)
        {
            int minimum = lists2[0];
            for (int i = 1; i < lists2.Count; i++)

            { if (lists2[i] <= minimum) { minimum = lists2[i]; } }

        
            return minimum;
        }
        public static int max(List<int> lists)
        {
            int maximum = lists[0];

            for (int j = 1; j < lists.Count; j++)
            {
                if (lists[j] >= maximum) { maximum = lists[j]; }
            }
            return maximum;
        }
   
        
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite n");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> lists = new List<int>();
            List<int> lists2 = new List<int>();
            List<int> lists3 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine().ToString();
                string[] text = s.Split(new char[] { ' ' });
                if (text[0] == "+")
                {
                    lists.Add(Convert.ToInt32(text[1]));
                    int chislo = max(lists)+1;
                    for (int f = 0; f <= chislo; f++)
                    { lists2.Add(f); }
                    for (int g = 0; g < lists.Count; g++)
                    {
                        for (int c = 0; c < lists2.Count; c++)
                        { if (lists[g] == lists2[c]) { lists2.RemoveAt(c); }
                                
                                    }
                    }
                   
                    lists3.Add(mex(lists2));
                    lists2.Clear();

                }

                if (text[0] == "-")
                {

                    for (int j = 0; j < lists.Count; j++)
                    {
                        if (lists[j] == Convert.ToInt32(text[1])) { lists.RemoveAt(j); break; }
                    }
                    if (lists.Count != 0)
                    {
                        int chislo = max(lists) + 1;
                        for (int f = 0; f <= chislo; f++)
                        { lists2.Add(f); }
                        for (int g = 0; g < lists.Count; g++)
                        {
                            for (int c = 0; c < lists2.Count; c++)
                            {
                                if (lists[g] == lists2[c]) { lists2.RemoveAt(c); }

                            }
                        }
                        lists3.Add(mex(lists2));
                        lists2.Clear();
                    }
                    else { lists3.Add(0); }
                }
            }
           
            Console.WriteLine();
           
            for (int i = 0; i < lists3.Count; i++)
            {
                Console.WriteLine(lists3[i]);
            }

            Console.Read();
        }

    }
}



