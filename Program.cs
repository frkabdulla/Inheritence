using System;

namespace Inheritence
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            product desk = new Desk();
            ((Desk)desk).TaxPercent= 2;
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

            product TDrone = new TurboDrone();
            TDrone.Price = 200;
            TDrone.Add();
            TDrone.Add();
            Console.WriteLine($"total value in Turbodrone is {TDrone.TotalValue()}");

            product SDrone = new StandardDrone();
            SDrone.Price = 500;
            SDrone.Add();
            SDrone.Add();
            Console.WriteLine($"total value in Standard drone is {SDrone.TotalValue()}");

          
            Console.ReadLine();


        }
    }
    public class TurboDrone : Drone
    {

    }
    public class StandardDrone : Drone
    {

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
            _quantity = _quantity + Qtyincremented;
        }

    }
    public class Desk : product
    {
        public decimal TaxPercent { get; set; }
        public Desk()
        {

        }
        public override decimal TotalValue()
        {
            decimal netTotal = base.TotalValue() - (base.TotalValue() * (TaxPercent / 100));
            return netTotal;
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
        public virtual Decimal TotalValue()
        {
            return _quantity * Price;
        }


    }
}
