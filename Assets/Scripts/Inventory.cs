using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, int> inventory = new Dictionary<string, int>();
    public TextMeshProUGUI inventoryText;
    
    private void Start()
    {
        inventory.Add("Sword", 4);
        inventory.Add("Potion", 3);
        
        UpdateInventoryText();
    }

    private void UpdateInventoryText()
    {
        inventoryText.text = "";
        
        foreach (var item in inventory)
        {
            inventoryText.text += item.Key + ": " + item.Value + "\n";
        }
    }

    public void IncreaseSwordCount()
    {
        if (inventory.ContainsKey("Sword"))
        {
            inventory["Sword"]++;
            UpdateInventoryText();
        }
    }

    public void DecreaseSwordCount()
    {
        if (inventory.ContainsKey("Sword") && inventory["Sword"] > 0)
        {
            inventory["Sword"]--;
            UpdateInventoryText();
        }
    }

    public void IncreasePotionCount()
    {
        if (inventory.ContainsKey("Potion"))
        {
            inventory["Potion"]++;
            UpdateInventoryText();
        }
    }

    public void DecreasePotionCount()
    {
        if (inventory.ContainsKey("Potion") && inventory["Potion"] > 0)
        {
            inventory["Potion"]--;
            UpdateInventoryText();
        }
    }
}