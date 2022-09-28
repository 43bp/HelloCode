Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "саша") // если username = Саша. ToLower() - переводит всё в нижний регситр во избежание ошибок в написании имени в части регистра букв!!! тут знак ; НЕ СТАВИМ! так как мы еще не закончили!
{
Console.WriteLine("Ура, это же Саша!");
}
else // иначе
{
Console.Write("Привет, ");
Console.WriteLine(username);
}