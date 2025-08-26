using BinaryCode.Classes;

//Code[0] = "01000001";//A
//Code[1] = "01000010";//B
//Code[2] = "01000011";//C
//Code[3] = "01000100";//D
//Code[4] = "01000101";//E
//Code[5] = "01000110";//F
//Code[6] = "01000111";//G
//Code[7] = "01001000";//H
//Code[8] = "01001001";//I
//Code[9] = "01001010";//J
//Code[10] = "01001011";//K
//Code[11] = "01001100";//L
//Code[12] = "01001101";//M
//Code[13] = "01001110";//N
//Code[14] = "01001111";//O
//Code[15] = "01010000";//P
//Code[16] = "01010001";//Q
//Code[17] = "01010010";//R
//Code[18] = "01010011";//S
//Code[19] = "01010100";//T
//Code[20] = "01010101";//U
//Code[21] = "01010110";//V
//Code[22] = "01010111";//W
//Code[23] = "01011001";//X
//Code[24] = "01011010";//Z

Binary start = new Binary();
Decipher_ decipher = new Decipher_();

string chain;
int num = 1;
bool check = true;

while (num != 3)
{
    try
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1- Cipher chain");
        Console.WriteLine("2- Decipher binary code");
        Console.WriteLine("3- Out\n");
        string num1 = Console.ReadLine();
        num = int.Parse(num1);
        check = true;
    }
    catch
    {
        Console.WriteLine("Write a valid character\n");
        check = false;
    }

    if (check)
    {
        switch (num)
        {
            case 1:
                Console.WriteLine("Write your characters: ");
                chain = Console.ReadLine();
                Console.WriteLine($"You´re cipher chain is {start.Cypher(chain)}\n");
                break;
            case 2:
                Console.WriteLine("Write your binary code: ");
                chain = Console.ReadLine();
                Console.WriteLine($"You're decipher code is {decipher.Decipher(chain)}\n");
                break;
            case 3:
                Console.WriteLine("Thanks for use our program!");
                break;
            default:
                Console.WriteLine("You must write valid data.\n");
                break;
        }
    }
}
