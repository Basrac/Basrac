using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public enum ItemType
{
    Equipment,
    Consumables,
    Etc
}
[System.Serializable]
public class Items 
{
    public ItemType itemtype;
    public string itemName;
    public string itemImage;

    public string sprite { get; internal set; }

    public bool Use()
    {
        return false;
    }
}

