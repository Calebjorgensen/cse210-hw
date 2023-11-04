using System;
using System.Runtime.CompilerServices;


class Menu
{
    public string _apps;
    public string _eentres;
    public string _deserts;

    public Menu()
    {
        Console.WriteLine("Welcome to Broken Barrell");
        Console.WriteLine("Heres our menu");
        Console.WriteLine("");
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
        Menu m = new Menu();
        m._apps = "Cheese Sticks";
        m._eentres = "Lets go nuts burger";
        m._deserts = "milkshakes";
        m.menuList();
      
    }    



}