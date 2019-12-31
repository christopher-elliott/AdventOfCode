using System;
using System.Collections.Generic;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int validPasswordCount = 0;
            for (int i = 153517; i <= 630395; i++)
            {
                if (PasswordValidator.ValidatePasswordV2(i))
                    validPasswordCount++;
            }
            Console.WriteLine($"validPasswordCount: {validPasswordCount}");
            
        }
    }
    public class PasswordValidator
    {
        
        public static bool ValidatePasswordV2(int password)
        {
            int[] pwDigits = GetIntArray(password);

            if (pwDigits.Length != 6)
                return false;

            int previousDigit = -1;
            bool repeat = false;
            for (int i=0; i < pwDigits.Length; i++)
            {
                if (pwDigits[i]==previousDigit)
                {
                    if (i < pwDigits.Length-1)
                    {
                        if (pwDigits[i]!=pwDigits[i+1])
                        {
                            repeat = true;
                        }
                        else
                        {
                            while (true)
                            {
                                if (i < pwDigits.Length-1)
                                {
                                    if (pwDigits[i]==pwDigits[i+1])
                                        i += 1;
                                    else
                                        break;
                                }
                                else
                                    break;
                            }
                        }
                    }
                    else
                    {
                        repeat = true;
                    }
                }
                if (pwDigits[i] < previousDigit)
                {
                    return false;
                }
                previousDigit = pwDigits[i];
            }
            return repeat;
        }

        public static bool ValidatePassword(int password)
        {
            int[] pwDigits = GetIntArray(password);

            if (pwDigits.Length != 6)
                return false;

            int previousDigit = -1;
            bool repeat = false;
            for (int i=0; i < pwDigits.Length; i++)
            {
                if (pwDigits[i]==previousDigit)
                {
                    repeat = true;
                }
                if (pwDigits[i] < previousDigit)
                {
                    return false;
                }
                previousDigit = pwDigits[i];
            }
            return repeat;
        }
        
        private static int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while(num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
        
    }
}
