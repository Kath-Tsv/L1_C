Console.Write("Enter username -> ");
string username = Console.ReadLine();

if (username.ToLower() == "Marry")
{
    Console.WriteLine("Welcome back, Marry!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}