Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username == "Маша") //Для того чтобы данное имя без разницы регистр if(username.ToLower() =="маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{    
    Console.Write("Привет, ");
    Console.WriteLine(username);
}    