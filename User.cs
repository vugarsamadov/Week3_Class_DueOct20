using System.Runtime.CompilerServices;

public class User
{
    public string Username;
    public string Password;

    public bool IsLoggedIn;

    public void Login()
    {
        string prompt = IsLoggedIn ? "Istifadəçi öncədən hesaba daxil olub" : "Istifadeci hesaba daxil oldu";
        Console.WriteLine(prompt);
        IsLoggedIn = true;    
    }

    public void Logout()
    {
        string prompt = IsLoggedIn ? "Istifadeci hesabdan cixis etdi" : "Istifadəçi hesaba giriş etməyib";
        Console.WriteLine(prompt);
        IsLoggedIn = false;
    }
    
    
    
    
}