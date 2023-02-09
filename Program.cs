using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            product desk= new Desk();
            desk.Price = 380;
            desk.Add();
            desk.Add();
            Console.WriteLine($"total value in stock is {desk.TotalValue()}");
            product drone = new Drone();

            drone.Price = 200;
            ((Drone)drone).Qtyincremented = 10;
            drone.Add();
            drone.Add();
            Console.WriteLine($"total value in drone is {drone.TotalValue()}");

            Console.ReadLine(); 
            
           
        }
    }
    public class Drone : product 
    {
        public int Qtyincremented { get; set; }
        public Drone()
        {
            Qtyincremented = 1;
        }
        public override void Add()
        {
            _quantity = _quantity+ Qtyincremented;
        }

    }
    public class Desk : product
    {
        public Desk() 
        {

        }
        public override void Add()
        {
            base.Add();
        }
    }

    public class product
    {
        protected int _quantity = 0;
        public decimal Price { get; set; }
        public product()
        {
            
        }
        public virtual void Add()
        {
            _quantity++;
        }
        public void Remove()
        {
            if (_quantity > 0)
            {
                _quantity--; 
            }

        }
        public Decimal TotalValue()
        {
            return _quantity*Price;
        }


    }
}
