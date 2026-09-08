using Generics_og_dokumentation;

Console.WriteLine("=== COLLECTION MED STRINGS ===");

Collection<string> names = new Collection<string>();

names.Add("Matthias");
names.Add("Anders");
names.Add("Mikkel");

Console.WriteLine($"Antal navne: {names.Count}");

string? foundName = names.Find(name => name == "Matthias");

Console.WriteLine($"Fundet: {foundName}");

bool removedName = names.Remove("Anders");

Console.WriteLine($"Anders blev fjernet: {removedName}");
Console.WriteLine($"Antal navne nu: {names.Count}");