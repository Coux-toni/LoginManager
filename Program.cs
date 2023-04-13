using LoginManager;

Generator gen = new Generator();
ErweiterterGenerator genExt = new ErweiterterGenerator();
genExt.Set("Sommer");
Console.WriteLine(gen.Generieren());
Console.WriteLine(genExt.Generieren());