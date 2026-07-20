using System.Collections.Generic; 
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public List<InventoryItem> playerInventory = new List<InventoryItem>();

  public void AddItem(Item item)
    {

        foreach (InventoryItem inventoryItem in playerInventory)
        {
            if (inventoryItem.item == item)
            {
                inventoryItem.amount += 1;
                return;
            }
        }
        InventoryItem newItem = new InventoryItem();
        newItem.item = item;
        newItem.amount = 1;
        playerInventory.Add(newItem);
    }

  public void RemoveItem(Item item)
    {
        foreach (InventoryItem inventoryItem in playerInventory)
        {
            if (inventoryItem.item == item)
            {
                inventoryItem.amount -= 1;
                if (inventoryItem.amount <=0)
                {
                    playerInventory.Remove(inventoryItem);
                }
                return;
            }
        }
        
    }
}

[System.Serializable]
public class InventoryItem
{
    public Item item;
    public int amount;

}
