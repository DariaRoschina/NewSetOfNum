using System;
using System.Collections.Generic;


namespace SetOfNumbers
{

    class Program
    {
        public static List<int> mex(List<int> lists)
        {
            List<int> lists2 = new List<int>();

            List<int> min = new List<int>();
            int maximum = lists[0];

            for (int j = 1; j < lists.Count; j++)
            {
                if (lists[j] > maximum) { maximum = lists[j]; }
            }


            for (int k = 0; k <= maximum + 1; k++)
            {
                lists2.Add(k);
            }


            for (int k = 0; k < lists.Count; k++)
            {
                List<int> lists3 = new List<int>();
                for (int j = 0; j < lists2.Count; j++)
                {
                    if (lists[k] != lists2[j]) { lists3.Add(lists2[j]); }
                }

                int minimum = lists3[0];
                for (int i = 1; i < lists3.Count; i++)

                { if (lists3[i] < minimum) { minimum = lists3[i]; } }

                min.Add(minimum);

            }


            return min;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("vvedite n");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> lists = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine().ToString();
                string[] text = s.Split(new char[] { ' ' });
                if (text[0] == "+") { lists.Add(Convert.ToInt32(text[1])); }

                if (text[0] == "-")
                {

                    for (int j = 0; j < lists.Count; j++)
                    {
                        if (lists[j] == Convert.ToInt32(text[1])) { lists.RemoveAt(j); break; }
                    }
                }
            }
            for (int i = 0; i < lists.Count; i++)
            {
                Console.WriteLine(lists[i]);
            }

            List<int> itog = mex(lists);
            for (int i = 0; i < itog.Count; i++)
            {
                Console.WriteLine(itog[i]);
            }

            Console.Read();
        }

    }
}



