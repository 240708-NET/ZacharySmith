// The Menu
//


//User will select a Appetizer
//User will select a Dinner
//User will select a Desert
//User will recieve a Bill

using System.Dynamic;
using Project0.Food;
using Project0.Data;
using Project0.RecieptModel;

namespace Project0.App;
//Classes
/*public class Food
{
    public double price;
}*/
/*public class Appetizer:Food
{
    public double GetAppetizer()
    {
        return price;
    }
}*/
/*public class Salad:Appetizer
{
    public Salad()
    {
        price = 5.00;
    }
}
public class Soup:Appetizer
{
    public Soup()
    {
        price = 5.50;
    }
}*/
/*public class Dinner:Food
{
    public double GetDinner()
    {
        return price;
    }
}*/
/*public class Fish:Dinner
{
    public Fish()
    {
        price = 11.00;
    }
}
public class Steak:Dinner
{
    public Steak()
    {
        price = 10.00;
    }
}*/
/*public class Dessert:Food
{
    public double GetDessert()
    {
        return price;
    }
}*/
/*public class Cheesecake:Dessert
{
    public Cheesecake()
    {
        price = 6.00;
    }
}
public class Pie:Dessert
{
    public Pie()
    {
        price = 5.50;
    }
}*/

//Main
class Prject0 { 
 
    static public void Main(String[] args) 
    { 
        //string connectionstring = "";
        IRepository file = new EFCore();

        //Variable Declaration
        int AppChoice;
        int DinChoice;
        int DesChoice;
        double AppCost;
        double DinCost;
        double DesCost;
        string app;
        string din;
        string des;
        double reciept = 0;

        //Instructions
        Console.WriteLine("Welcome to the Restaurant.");
        Console.WriteLine("You will be asked to input a number that");
        Console.WriteLine("corresponds with a Appetizer, Dinner and");
        Console.WriteLine("Dessert. \n\n\n");

        //Appetizer Selection
        Console.WriteLine("For an Appetizer, would you like:");
        Console.WriteLine("1. Salad - $5.00\n2. Soup - $5.50\n0. Nothing");
        AppChoice = Convert.ToInt32(Console.ReadLine());
        
        //Dinner Selection
        Console.WriteLine("For an Dinner, would you like:");
        Console.WriteLine("1. Fish - $11.00\n2. Steak - $10.00\n0. Nothing");
        DinChoice = Convert.ToInt32(Console.ReadLine());
        
        //Dessert Selection
        Console.WriteLine("For an Dessert, would you like:");
        Console.WriteLine("1. Cheesecake - $6.00\n2. Pie - $5.50\n0. Nothing");
        DesChoice = Convert.ToInt32(Console.ReadLine());
        
        //Appetizer Logic
        if(AppChoice == 1)
        {
            Salad salad = new Salad();
            reciept = reciept + salad.GetAppetizer();
            AppCost = salad.GetAppetizer();
            app = "Salad";
        }
        else if(AppChoice == 2)
        {
            Soup soup = new Soup();
            reciept = reciept + soup.GetAppetizer();
            AppCost = soup.GetAppetizer();
            app = "Soup";
        }
        else
        {
            reciept = reciept + 0;
            AppCost = 0;
            app = "None";
        }

        //Dinner Logic
        if(DinChoice == 1)
        {
            Fish fish = new Fish();
            reciept = reciept + fish.GetDinner();
            DinCost = fish.GetDinner();
            din = "Fish";
        }
        else if(DinChoice == 2)
        {
            Steak steak = new Steak();
            reciept = reciept + steak.GetDinner();
            DinCost = steak.GetDinner();
            din = "Steak";
        }
        else
        {
            reciept = reciept + 0;
            DinCost = 0;
            din = "None";
        }

        //Dessert Logic
        if(DesChoice == 1)
        {
            Cheesecake cheesecake = new Cheesecake();
            reciept = reciept + cheesecake.GetDessert();
            DesCost = cheesecake.GetDessert();
            des = "Cheesecake";
        }
        else if(DesChoice == 2)
        {
            Pie pie = new Pie();
            reciept = reciept + pie.GetDessert();
            DesCost = pie.GetDessert();
            des = "Pie";
        }
        else
        {
            reciept = reciept + 0;
            DesCost = 0;
            des = "None";
        }

        //Reciept Print
        Console.WriteLine("Thank you for eating at the Restaurant\n");
        Console.WriteLine("Your Bill\n-----------------------------\n");
        if(AppChoice == 1)
        {
            Console.WriteLine("Salad            $ " + AppCost.ToString("F"));
        }
        else if(AppChoice == 2)
        {
            Console.WriteLine("Soup             $ " + AppCost.ToString("F"));
        }
        else
        {
            Console.WriteLine("Nothing          $ " + AppCost.ToString("F"));
        }
        if(DinChoice == 1)
        {
            Console.WriteLine("Fish             $ " + DinCost.ToString("F"));
        }
        else if(AppChoice == 2)
        {
            Console.WriteLine("Steak            $ " + DinCost.ToString("F"));
        }
        else
        {
            Console.WriteLine("Nothing          $ " + DinCost.ToString("F"));
        }
        if(DesChoice == 1)
        {
            Console.WriteLine("Cheesecake       $ " + DesCost.ToString("F"));
        }
        else if(AppChoice == 2)
        {
            Console.WriteLine("Pie              $ " + DesCost.ToString("F"));
        }
        else
        {
            Console.WriteLine("Nothing          $ " + DesCost.ToString("F"));
        }
        Console.WriteLine("\n-----------------------------\n");
        Console.WriteLine("Total:               $" + reciept.ToString("F"));

        Reciept myReciept = new Reciept(reciept, app, din, des, DateTime.Now);

        try
        {
            file.SaveReciept(myReciept);
            Console.WriteLine("Save Complete");
        }
        catch(Exception e)
        {
            Console.WriteLine( e.Message );
        }
    } 
} 