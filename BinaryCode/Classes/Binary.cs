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
            string cypherChain, correctChain;
            char cypher;
            int numC = 0, character, totalCypher;
            string resultado = "";
            while (numC < chain.Length)
            {
                cypherChain = "";
                correctChain = "";
                cypher = chain[numC];
                character = (int)(cypher);
                for (int i = 0; i < 7; i++) 
                {
                    totalCypher = character % 2;
                    character = character / 2;
                    Console.WriteLine(character);
                    cypherChain += totalCypher;
                }
                cypherChain += "0";
                for (int i = 7; i >= 0; i--) 
                { 
                    correctChain += cypherChain[i];
                }
                resultado += correctChain;
                Console.WriteLine(resultado);
                numC++;
            }
            return resultado;
        }
    }
}
