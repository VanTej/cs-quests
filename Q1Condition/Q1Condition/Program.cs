// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saisir limite 1");
string limit1 = Console.ReadLine();
Console.WriteLine("Saisir limite 2");
string limit2 = Console.ReadLine();
Console.WriteLine("Saisir la valeur à tester");
string toCompare = Console.ReadLine();
int l1 = int.Parse(limit1);
int l2 = int.Parse(limit2);
int intToCompare = int.Parse(toCompare);

if (intToCompare < l1)
{
    Console.WriteLine($"You have entered {intToCompare} which is lower than {l1} which is the minimum");
    Console.WriteLine($"Resulting integer : {l1}");
}
else if (intToCompare > l2)
{
    Console.WriteLine($"You have entered {intToCompare} which is greater than {l2} which is the maximum");
    Console.WriteLine($"Resulting integer : {l2}");
}
else
{
    Console.WriteLine($"You have entered {intToCompare} which is between {l1} and {l2}");
}