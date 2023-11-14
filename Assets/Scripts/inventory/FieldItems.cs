using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldItems : MonoBehaviour
{
    public Item item;
    public SpriteRenderer image;

    public void SetItem(Item _item)
    {
        item.itemName = _item.itemName;
        item.itemImage = _item.itemImage;
        item.itemtype = _item.itemtype;

        item.sprite = item.itemImage;
    }
    public Item GetlItem()
    {
        return item;
    }

    public void DestroyItem()
    {
        Destroy(gameObject);
    }
}
