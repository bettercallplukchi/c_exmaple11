using System.Runtime.Serialization;

string a1 = Console.ReadLine()!;
string a2 = Console.ReadLine()!;

int b1 = Convert.ToInt32(a1);
int b2 = Convert.ToInt32(a2);

if (b1 * b1 == b2)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
