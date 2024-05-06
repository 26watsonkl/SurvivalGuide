using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class item : MonoBehaviour
{
    public string name;
    public int ID;
    public Sprite icon;

    public enum ItemType
    {
        None,
        Weapon,
        Consumable,
    }
    public ItemType itemtype;

    public void Action()
    {
        switch(ItemType)
        {
            case ItemType.Weapon:
            Debug.Log("This is a: " + itemtype);
            break;

            case ItemType.Consumable:
            Debug.Log("This is a consumable");
            break;
        }
    }
}
