using Project0.Food;
using Project0.App;

namespace Project0.Data
{
    public interface IRepository
    {
        void SaveReciept(Double Reciept, String app, String din, String des);
    }
}