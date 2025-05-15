using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atbash_cipher_project
{
    internal class Program
    {
        static string AtbashSDecrypt(string text)
        {
            string result = "";
            char decrypt;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    decrypt = (char) ('z' - (char.ToLower(c) - 'a'));
                    result += decrypt;
                }
                else
                {
                    result += c;   
                }
            }
            
            return result;
        }

            static void Main(string[] args)
            {

            }
        }
    }
