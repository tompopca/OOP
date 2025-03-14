using cv06;

GrObjekt[] pole = new GrObjekt[] {
                    new Kruh(2),
                    new Elipsa(3, 5),
                    new Jehlan(5, 10, 3),
                    new Koule(5),
                    new Kvadr(2, 4, 8),
                    new Obdelnik(4, 7),
                    new Trojuhelnik(3, 4, 5),
                    new Valec(3, 12)
            };

double plocha = 0;
double povrch = 0;
double objem = 0;

foreach (var c in pole)
{
    c.Kresli();
    if (c is Objekt2D)
    {

        plocha += ((Objekt2D)c).SpoctiPlochu();
        Console.WriteLine($"Plocha je: {plocha}\n");
    }
    else
    {
        povrch += ((Objekt3D)c).SpoctiPovrch();
        objem += ((Objekt3D)c).SpoctiObjem();
        Console.WriteLine($"Povrch je: {povrch}, Objem je: {objem}\n");

    }
}

Console.ReadLine();
