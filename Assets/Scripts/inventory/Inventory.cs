using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
  

    public delegate void OnSlotCountChange(int vla);
    public OnSlotCountChange onSlotCountChange;
    private int slotCnt;
    internal static Inventory instance;

    public int SlotCnt
    {
        get => slotCnt;
        set
        {
            slotCnt = value;
            onSlotCountChange.Invoke(slotCnt);
        }
    }
    
    void Start()
    {
        SlotCnt = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
