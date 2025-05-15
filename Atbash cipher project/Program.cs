using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Atbash_cipher_project
{
    internal class Program
    {
              
         static int WarningCounter(string text)
        {
            string[] dangerousWords = { "bomb", "nukhba", "fighter", "rocket", "secret" };
            string[] splitText = text.Split(' ');
            int point = 0;

            foreach(string word in splitText)
            {
                if (dangerousWords.Contains(word))
                {
                    point++;
                }
            }
            return point;
        }

            static void Main(string[] args)
            {

            }
        }
    }
