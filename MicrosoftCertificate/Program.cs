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


Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 10; 
//more than one day remaining
string message = "Your subscripcion expires in " + daysUntilExpiration + " days.\n Renew now and save " + discountPercentage+"%!";
if (daysUntilExpiration == 1)
{
    //one day remaining 
    discountPercentage = 20;
    message="Your subscripcion expires within a day.\n Renew now and save " + discountPercentage + "%!";
}
else if (daysUntilExpiration == 0)
{
    //expired
    message = "Your subscription has expired.";

}
Console.WriteLine(message);




// students names 
string[] students = new string[] {"marek","arek","darek"};
// scores of students
int[] asimentScores = new int[] { 90, 30, 70 };
int i = 0;
//writing a report of students scores
foreach(int a in asimentScores)
{
    // printing a scores  
    Console.WriteLine("Student: " + students[i]+" Score on asiment: " + asimentScores[i]);
    i++;

}

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

