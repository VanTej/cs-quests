// See https://aka.ms/new-console-template for more information
Dictionary<char, List<string>> dico = new Dictionary<char, List<string>>();
dico['a'] = new List<string> { "anticonstitutionnellement", "armagedon", "azur" };
dico['b'] = new List<string> { "bière", "bouteille", "bulle" };
dico['c'] = new List<string> { "canabis", "clé", "cordialement" };
Console.WriteLine("a :");
foreach (string s in dico['a'])
{
    Console.WriteLine(s);
}
Console.WriteLine("b :");
foreach (string s in dico['b'])
{
    Console.WriteLine(s);
}
Console.WriteLine("c :");
foreach (string s in dico['c'])
{
    Console.WriteLine(s);
}
dico.Remove('c');