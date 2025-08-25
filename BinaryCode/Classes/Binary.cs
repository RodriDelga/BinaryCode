using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCode.Classes
{
    public class Binary
    {
        public string Cypher(string chain)
        {
            string cipherChain, correctChain;
            char cipher;
            int numC = 0, character, totalCypher;
            string resultado = "";
            while (numC < chain.Length)
            {
                cipherChain = "";
                correctChain = "";
                cipher = chain[numC];
                character = (int)(cipher);
                for (int i = 0; i < 7; i++) 
                {
                    totalCypher = character % 2;
                    character = character / 2;
                    // Console.WriteLine(character);
                    cipherChain += totalCypher;
                }
                cipherChain += "0";
                for (int i = 7; i >= 0; i--) 
                { 
                    correctChain += cipherChain[i];
                }
                resultado += correctChain + " ";
                // Console.WriteLine(resultado);
                numC++;
            }
            return resultado;
        }
    }
}
