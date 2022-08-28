// See https://aka.ms/new-console-template for more information
List<string> names = new List<string>();
names.Add("Vanessa");
names.Add("Vaness");
names.Add("Van");
foreach (string item in names)
{
    Console.WriteLine($"Hello, {item}!");
}
names[1] = "VANESSA";
names.RemoveAt(0);
names.Remove("Van");
foreach (string item in names)
{
    Console.WriteLine($"Bye, {item}!");
}