using System;



class Menu
{
    public string _apps;
    public string _eentres;
    public string _deserts;
    public string name;
    private string secret;

    public string Secret
    {
        get{return secret;}
        set{name = value;}
    }

    public Menu(string n)
    {
        Console.WriteLine("Welcome to Broken Barrell");
        Console.WriteLine("Heres our menu");
        Console.WriteLine("");
        name = n;
        
    }

    public string getName()
    {
        return name;
    }

    public void menuList()
    {
        Console.WriteLine($"appetizers: {_apps}\nEetnres: {_eentres}\nDeserts: {_deserts}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Menu m = new Menu("Caleb");
        m.Secret = "Secret Menu";
        m._apps = "Cheese Sticks";
        m._eentres = "Lets go nuts burger";
        m._deserts = "milkshakes";
        m.menuList();
        Console.WriteLine(m.getName());
        Console.WriteLine(m.Secret);
      
    }    



}