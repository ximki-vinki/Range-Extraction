using System;
using System.Text;


namespace Range_Extraction
{
    internal class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            int[] arrayMinus = new int[args.Length];
            StringBuilder sb = new StringBuilder();
            sb.Append(args[0]);

            for (int i = 1; i < args.Length; i++) arrayMinus[i] = args[i] - args[i - 1] - 1;

            int count = 0;
            for (int i = args.Length - 1; i > 0; i--)
            {
                if (arrayMinus[i] == 0)
                {
                    arrayMinus[i] = count;
                    count--;
                }
                else count = 0;
            }
            for (int i = 1; i < args.Length; i++)
            {
                if (arrayMinus[i] > 0) sb.Append("," + args[i]);
                else if (arrayMinus[i] < 0)
                {
                    i -= arrayMinus[i];
                    sb.Append("-" + args[i]);
                }
                else sb.Append("," + args[i]);
            }
            return sb.ToString();
        }
    }
}
