using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Item[] itemList = new Item [4];
    public List<InventorySlot> inventorySlots = new List<InventorySlot>();

    public bool AddItem(Item item)
    {
        for (int i =0; i < itemList.Length; i++)
        {
            if (itemList[i] == null)
            {

                itemList[i] = item;
                return true;

            }
        }
        return false;
    }


}
