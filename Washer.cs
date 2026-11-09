using System;

namespace RepairCenter
{
    public class Washer : Appliance
    {
        public Washer(string brand, string model)
            : base(brand, model) { }

        public override void ReceiveDevice()
        {
            Console.WriteLine("Washer received.");
        }

        public override void StartRepair()
        {
            Console.WriteLine("Washer repair started.");
        }

        public override void CompleteRepair()
        {
            Console.WriteLine("Washer repair completed.");
        }
    }
}