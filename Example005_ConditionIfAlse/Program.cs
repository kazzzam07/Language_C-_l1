Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура это жe Маша!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}