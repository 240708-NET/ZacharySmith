

namespace Project0.RecieptModel;
using System.ComponentModel.DataAnnotations;
public class Reciept
{
    [Key]
    public int RecieptNum{ get; set;}

    [Required]
    public double totalPrice{get; set;}
    public string App { get; set; }
    public string Din { get; set; }
    public string Des { get; set; }
    public DateTime date { get; set; }

    public Reciept(double total, string App, string Din, string Des, DateTime Date)
    {
        totalPrice = total;
        this.App = App;
        this.Din = Din;
        this.Des = Des;
        this.date = Date;
    }

    public Reciept(int num, double total, string App, string Din, string Des, DateTime Date)
    {
        this.RecieptNum = num;
        totalPrice = total;
        this.App = App;
        this.Din = Din;
        this.Des = Des;
        this.date = Date;
    }

    public Reciept(){}
    
}