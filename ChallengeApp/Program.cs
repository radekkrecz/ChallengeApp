int number = 7809;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int[] counter = new int[10];

foreach(var count in counter)
    counter[count] = 0;

foreach (char letter in letters)
{
    counter[int.Parse($"{letter}")]++;
}

Console.WriteLine("Wyniki dla liczby: " +  numberAsString);

for(int i = 0; i < counter.Length; i++)
{
    Console.WriteLine(i + "=>" + counter[i]);
}