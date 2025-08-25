using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCode.Classes
{
    public class Decipher_
    {
        public string Decipher(string chain)
        {
            int total;
            char decipher;
            string[] codeArray = new string[8];
            string code = "";
            while (!string.IsNullOrEmpty(chain))
            {
                if (!string.IsNullOrEmpty(chain))
                {
                    if (chain.Length < 8)
                    {
                        for (int i = 0; i < chain.Length; i++)
                        {
                            codeArray[i] = "" + chain[i];
                        }
                        for (int i = chain.Length; i < 8; i++)
                        {
                            codeArray[i] = "" + 0;
                        }

                    }
                    else
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            codeArray[i] = "" + chain[i];
                        }
                        chain = chain.Substring(8);
                    }
                }
                //for (int i = 0; i < codeArray.Length; i++)
                //{
                //    Console.WriteLine($"Arreglo[{i}]={codeArray[i]}");
                //}
                total = Transform(codeArray);
                decipher = (char)total;
                code += decipher;
            }
            return code;
        }
        public int Transform(string[] codeArray) 
        {
            int total = 0, ceros, counter = 1;
            for (int i = 7; i >= 0; i--) 
            { 
                ceros = int.Parse(codeArray[i]);
                ceros *= counter;
                total += ceros;
                counter *= 2;
            }
            return total;
        }
    }
}
