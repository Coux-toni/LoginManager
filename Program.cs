using LoginManager;

Generator gen = new Generator();
ErweiterterGenerator genExt = new ErweiterterGenerator();
genExt.Set("Sommer");
Console.WriteLine(gen.Generieren());
Console.WriteLine(genExt.Generieren());
Manager n = new();
Passwort p1 = new("Dorpbox", genExt.Generieren());
n.Speichern(p1);
Passwort p2 = new("Dorpbox", genExt.Generieren());
n.Speichern(p2);
