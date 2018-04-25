using System;

namespace HackerEarth.Hiring.HoneyWell_11_26
{
    class Program2
    {
        static char[] _alpha = new char[]
			{ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
				'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public static void Execute()
        {

            int q, MAX_COUNT = 26;
            string s;

            bool verified;

            q = int.Parse(Console.ReadLine());

            for (int k = 0; k < q; k++)
            {
                int count = 0;
                s = Console.ReadLine();

                for (int i = 0; i <= (s.Length - MAX_COUNT); i++)
                {
                    for (int j = i + MAX_COUNT - 1; j < s.Length; j++)
                    {
                        verified = verify(s.Substring(i, j - i + 1));
                        if (verified == true) count++;
                    }
                }

                Console.WriteLine(count.ToString());
                Console.ReadKey();
            }
        }

        private static bool verify(string v)
        {
            bool result = true;

            foreach (char c in _alpha)
            {
                if (v.IndexOf(c) == -1)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
