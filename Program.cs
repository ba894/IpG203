using System;

namespace RepairCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Appliance fridge = new Fridge("Samsung", "RF-100");
            Appliance washer = new Washer("LG", "WM-200");
            Appliance ac = new AirConditioner("Gree", "AC-300");

            Appliance[] devices = { fridge, washer, ac };

            foreach (Appliance device in devices)
            {
                device.DisplayInfo();
                device.ReceiveDevice();
                device.StartRepair();
                device.CompleteRepair();

                Console.WriteLine("----------------------");
            }
        }
    }
}