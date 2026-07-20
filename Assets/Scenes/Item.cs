using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "New Item")]

public class Item : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public int cost;
    public Sprite itemSprite;

    public enum ItemType
    {
        consumable,
        weapon,
        armor,
        keyItem
    }

}

