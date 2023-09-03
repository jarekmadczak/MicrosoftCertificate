//Random seed = new Random();
//int random = seed.Next(1,6);
//Console.WriteLine("this is your random number: "+ random);

//int firstValue = 300;
//int secondValue = 400;
//int largerValue= System.Math.Max(firstValue, secondValue);
//Console.WriteLine(largerValue);

Random dice = new Random();
int roll1 = dice.Next(1, 6);
int roll2 = dice.Next(1, 6);
int roll3 = dice.Next(1, 6);
int total = roll1 + roll2 + roll3;
Console.WriteLine("Dice roll: "+roll1+" + "+roll2+" + "+" + "+roll3+" = "+total);

if (total < 8)
{
    Console.WriteLine("YOU lose");
}
else
{
    Console.WriteLine("YOU win");
}

string msg = "dog and fox are walking down the road";
bool result = msg.Contains("dog");
if (result)
{
    Console.WriteLine("There is dog in that sentence");

}
if (!result)
{
    Console.WriteLine("There is no dog in that sentence");
}
