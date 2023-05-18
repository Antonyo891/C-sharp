// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет! Как тебя зовут?");
string username = Console.ReadLine();
if(username.ToLower()=="степан")
{
    Console.WriteLine("Ура!!! Это ведь Степан");
    }
else 
{
    Console.Write("Как жаль что это не степан(((...Привет, ");
    Console.WriteLine(username);
}
