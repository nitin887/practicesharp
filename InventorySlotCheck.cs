using System;
namespace InventorySlot
{
    class InventorySlotCheck
    {
        static void Main()
        {
            int[] inventory=[1,1,0,1,0];
           int freeSlot=0;
            for(int i = 0; i < inventory.Length; i++) {
                if (inventory[i]==0)
                {
                    freeSlot++;
                }
               
            }
            Console.WriteLine("free slot :"+freeSlot);
            
        }
    }
}