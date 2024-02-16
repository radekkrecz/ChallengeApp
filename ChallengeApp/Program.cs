string name = "Ewa";
bool women = false;
int age = 10;

if (women && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (women && name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (!women && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}