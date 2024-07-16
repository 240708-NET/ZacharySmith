// The Menu
//


//User will select a Appetizer
//User will select a Dinner
//User will select a Desert
//User will recieve a Bill

using System.Dynamic;


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
        //Variable Declaration
        int AppChoice;
        int DinChoice;
        int DesChoice;
        double AppCost;
        double DinCost;
        double DesCost;
        Double Reciept = 0;

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
            Reciept = Reciept + salad.GetAppetizer();
            AppCost = salad.GetAppetizer();
        }
        else if(AppChoice == 2)
        {
            Soup soup = new Soup();
            Reciept = Reciept + soup.GetAppetizer();
            AppCost = soup.GetAppetizer();
        }
        else
        {
            Reciept = Reciept + 0;
            AppCost = 0;
        }

        //Dinner Logic
        if(DinChoice == 1)
        {
            Fish fish = new Fish();
            Reciept = Reciept + fish.GetDinner();
            DinCost = fish.GetDinner();
        }
        else if(DinChoice == 2)
        {
            Steak steak = new Steak();
            Reciept = Reciept + steak.GetDinner();
            DinCost = steak.GetDinner();
        }
        else
        {
            Reciept = Reciept + 0;
            DinCost = 0;
        }

        //Dessert Logic
        if(DesChoice == 1)
        {
            Cheesecake cheesecake = new Cheesecake();
            Reciept = Reciept + cheesecake.GetDessert();
            DesCost = cheesecake.GetDessert();
        }
        else if(DesChoice == 2)
        {
            Pie pie = new Pie();
            Reciept = Reciept + pie.GetDessert();
            DesCost = pie.GetDessert();
        }
        else
        {
            Reciept = Reciept + 0;
            DesCost = 0;
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
        Console.WriteLine("Total:               $" + Reciept.ToString("F"));
    } 
} 