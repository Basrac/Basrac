using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 1;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            TakeDamage(10);
        }

    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            gameObject.SetActive(false);

            Invoke("MoveToNextScene", 0.01f);
        }
    }

    public void MoveToNextScene()
    {
        SceneManager.LoadScene("GameOver");

    }
}