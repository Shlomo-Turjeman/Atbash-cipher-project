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

        static string AtbashSDecrypt(string text)
        {
            string result = "";
            char decrypt;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    decrypt = (char)('z' - (char.ToLower(c) - 'a'));
                    result += decrypt;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

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


        static void FinalPrint(string text, int point)
        {
            string warning = "";

            if (point >= 1 && point <= 5)
            {
                warning = "WARNING";
            }
            else if (point >= 6 && point <= 10)
            {
                warning = "DANGER";
            }
            else if (point >= 11 && point <= 15)
            {
                warning = "ULTRA DANGER";
            }

            Console.WriteLine($"Message: {text} \nWorning: {warning} \nTotal points: {point}");
        }

        static void Main(string[] args)
            {

            }
        }
    }
