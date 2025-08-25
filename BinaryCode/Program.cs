using BinaryCode.Classes;

Binary start = new Binary();
Decipher_ decipher = new Decipher_();

string chain;
int num;

Console.WriteLine("What would you like to do?");
Console.WriteLine("1- Cipher chain");
Console.WriteLine("2- Decipher binary code");
num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Write your characters:");
        chain = Console.ReadLine();
        Console.WriteLine($"You´re cipher chain is {start.Cypher(chain)}");
        break;
    case 2:
        Console.WriteLine("Write your binary code: ");
        chain = Console.ReadLine();
        Console.WriteLine($"You're decipher code is {decipher.Decipher(chain)}");
        break;
    default:
        Console.WriteLine("You must write valid data.");
        break;
}
