using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBtn : MonoBehaviour
{
    public bool IsButtonDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsButtonDown)
        {
            //¸í·É¾î
        }
    }

    public void PointerDown()
    {
        IsButtonDown = true;
    }

    public void PointerUp()
    {
        IsButtonDown = false;
    }
}
