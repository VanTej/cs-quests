// See https://aka.ms/new-console-template for more information
int[] unity = new int[5];
unity[0] = 0;
unity[1] = 1;
unity[2] = 2;
unity[3] = 3;
unity[4] = 4;
int[] dec = new int[5];
dec[0] = 10;
dec[1] = 11;
dec[2] = 12;
dec[3] = 13;
dec[4] = 14;
int[] fusion = new int[10];
for (int i = 0; i < unity.Length; i++)
{
	fusion[i] = unity[i];
	fusion[i + unity.Length] = dec[i];

}

foreach (var item in fusion)
{
	Console.WriteLine(item);
}
