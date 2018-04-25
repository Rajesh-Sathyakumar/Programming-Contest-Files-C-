using System;


namespace HackerEarth.Hiring.HoneyWell_11_26
{
    class Program1
    {
        public static void Execute()
        {
            int n;
            string result = string.Empty;

            n = int.Parse(Console.ReadLine());
            int[] p = new int[n];
            bool[] pTest = new bool[n];

            var str = Console.ReadLine().Split(' ');

            for(int i = 0; i<n; i++)
            {
                p[i] = int.Parse(str[i]);
            }

            for(int i = 0; i<n ;i++)
            {
                for (int j = i + 1; j<n; j++) {
                    if (p[i] > p[j]) pTest[j] = true;
                }
            } 

            for(int i = 0; i<n; i++)
            {
                if (pTest[i] == false) result += (i+1).ToString() +" ";
            }

            Console.WriteLine(result.Substring(0, result.Length - 1));
            Console.ReadKey();
        }
    }
}