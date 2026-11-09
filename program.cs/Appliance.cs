using System;
 
  namespace RepairCenter
{
    public abstract class Appliance : IRepairable
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        protected Appliance(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public abstract void ReceiveDevice();
        public abstract void StartRepair();
        public abstract void CompleteRepair();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }
    }
}