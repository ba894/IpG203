using System;

namespace RepairCenter
{
    public class Fridge : Appliance
    {
        public Fridge(string brand, string model)
            : base(brand, model) { }

        public override void ReceiveDevice()
        {
            Console.WriteLine("Fridge received.");
        }

        public override void StartRepair()
        {
            Console.WriteLine("Fridge repair started.");
        }

        public override void CompleteRepair()
        {
            Console.WriteLine("Fridge repair completed.");
        }
    }
}