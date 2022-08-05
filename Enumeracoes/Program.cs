using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main (string[] args)
        {
            var order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os;
            Enum.TryParse("Delivered",out os);
            
            Console.WriteLine(os); 
            Console.WriteLine(txt); 
        }
    }
}