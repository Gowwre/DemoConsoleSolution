// See https://aka.ms/new-console-template for more information

string[] names = { "Vee", "Blo", "HaDo", "Xvier","Sing" };
//Standard
bool CheckName(string s) => s.EndsWith('g');
var dataResult = names.Where(n => n.EndsWith('g'));
foreach (var name in dataResult)
{
    Console.WriteLine(name);
}