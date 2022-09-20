// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

string permission = "Manager";
int level = 20;

if (level > 55)
{
    if (permission.Contains("Admin"))
    {
        Console.WriteLine("Welcome, Super Admin");
    }
    else if (permission.Contains("Manager"))
    {
        Console.WriteLine("Contact Admin");
    }
}
else if (level >= 20)
{
    if (permission.Contains("Admin"))
    {
        Console.WriteLine("Welcome, Admin");
    } else if (permission.Contains("Manager"))
    {
        Console.WriteLine("Contact Admin");
    }
}
else
{
    if (permission.Contains("Admin"))
    {
        Console.WriteLine("Welcome Admin");
    }
    else
    {
        Console.WriteLine("You don't have sufficient privileges");
    }
}