// See https://aka.ms/new-console-template for more information

try
{
    using var reader = new System.IO.StreamReader(@"D:\vee.txt");
    var content = reader.ReadToEnd();
    Console.WriteLine($"File length:{content.Length}");
}
catch (System.IO.FileNotFoundException fileNotFoundException)
{
    Console.WriteLine(fileNotFoundException.Message);
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}