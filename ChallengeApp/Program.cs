string imie = "Ewa";
bool kobieta = false;
int wiek = 10;

if (kobieta && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (kobieta && imie == "Ewa" && wiek == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (!kobieta && wiek < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}