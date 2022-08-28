// See https://aka.ms/new-console-template for more information

int x = int.MaxValue;
long y = long.MaxValue;
short z = short.MaxValue;
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

ulong result = (ulong)x + (ulong)y + (ulong)z;
Console.WriteLine(result);