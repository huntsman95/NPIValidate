using System;

namespace NPIValidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { Console.WriteLine(checkLuhn(args[0])); }
            catch { Console.WriteLine("False"); }
        }

        static bool checkLuhn(String NPINumber)
        {
            if(NPINumber.Length != 10)
            {
                return false;
            }
            NPINumber = string.Format("80840{0}",NPINumber);
            int nDigits = NPINumber.Length;
            int nSum = 0;
            bool isSecond = false;
            for (int i = nDigits - 1; i >= 0; i--)
            {
                int d = NPINumber[i] - '0';
                if (isSecond == true)
                {
                    d = d * 2;
                }
                nSum += d / 10;
                nSum += d % 10;
                isSecond = !isSecond;
            }
            return (nSum % 10 == 0);
        }
    }
}
