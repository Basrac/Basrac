using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldItems : MonoBehaviour
{
    public Items items;
    public SpriteRenderer image;

    public void SetItem(Items _item)
    {
        items.itemName = _item.itemName;
        items.itemImage = _item.itemImage;
        items.itemtype = _item.itemtype;

        items.sprite = items.itemImage;
    }
  

    public void DestroyItem()
    {
        Destroy(gameObject);
    }
}
