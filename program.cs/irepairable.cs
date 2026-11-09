namespace RepairCenter
{
    public interface IRepairable
    {
        void ReceiveDevice();
        void StartRepair();
        void CompleteRepair();
    }
}