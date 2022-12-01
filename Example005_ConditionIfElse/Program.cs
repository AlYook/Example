Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "danil")
{
    Console.WriteLine("Ура, это же ДАНИЛ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}