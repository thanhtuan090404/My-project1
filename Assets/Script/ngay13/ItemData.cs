using UnityEngine;
// Enum độ hiếm
public enum ItemRarity
{
    Common,
    Rare,
    Epic
}


[CreateAssetMenu(fileName = "itemName", menuName = "Inventory/Item" )]
public class ItemData : ScriptableObject
{
    public string itemName;
    public int value;
    public ItemRarity rarity;

}
