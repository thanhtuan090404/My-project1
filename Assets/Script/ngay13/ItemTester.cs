using UnityEngine;

public class ItemTester : MonoBehaviour
{
    public ItemData itemData;

    public int _value;
    public ItemRarity _itemRarity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _value = itemData.value;
        _itemRarity = itemData.rarity;
        Debug.Log($"Item {itemData.itemName} có giá trị {itemData.value} và độ hiếm {itemData.rarity}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
