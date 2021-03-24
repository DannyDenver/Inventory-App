using System;

namespace InventoryApp
{
    [Serializable]
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int partID, string name, decimal price, int inventory, int min, int max, int machineID): base(partID, name, price, inventory, min, max)
        {
            MachineID = machineID;
        }
    }
}
