using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    public GameObject gameClearPopup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameClearPopup.SetActive(true);
        }
    }
}
