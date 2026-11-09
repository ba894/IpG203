using System;

namespace RepairCenter
{
    public class AirConditioner : Appliance
    {
        public AirConditioner(string brand, string model)
            : base(brand, model) { }

        public override void ReceiveDevice()
        {
            Console.WriteLine("Air Conditioner received.");
        }

        public override void StartRepair()
        {
            Console.WriteLine("Air Conditioner repair started.");
        }

        public override void CompleteRepair()
        {
            Console.WriteLine("Air Conditioner repair completed.");
        }
    }
}