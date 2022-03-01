using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02._22
{
    internal class Caesar
    {
        private static string AlphabetRU =
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static string Encrypty(string input, int key)
        {
            input = input.ToUpper();

            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                int inputIndex = AlphabetRU.IndexOf(input[i]);
                if (inputIndex != -1)
                {
                    output += AlphabetRU[(inputIndex + key) % AlphabetRU.Length];
                }
                else
                    output += input[i];

            }
            return output;
        }
        public static string Decrypt(string input, int key)
        {
            input = input.ToUpper();

            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                int inputIndex = AlphabetRU.IndexOf(input[i]);
                if (inputIndex != -1)
                {
                    output += AlphabetRU[(AlphabetRU.Length + inputIndex - key)
                            % AlphabetRU.Length];
                    
                   
                }
                else
                    output += input[i];

            }
            return output;
        }
    }
}
