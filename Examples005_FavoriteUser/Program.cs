Console.WriteLine("Введи имя юзера");
string username = Console.ReadLine();

if(username.ToLower() == "artem")
{
    Console.WriteLine("Ух это Artem!!!");
}
else
{
    Console.Write("Привет ,");
    Console.WriteLine(username);
}