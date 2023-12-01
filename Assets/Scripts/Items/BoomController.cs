using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour
{
    public float explosionForce = 10f; 
    public float explosionRadius = 5f; // ÆøÅº ¹üÀ§
    
    public enum Type { Boom };
    public Type type;
    public int value;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Explode();
        }
    }

  
    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (var collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }

            DestroyWall(collider.gameObject);
        }


        Destroy(gameObject);
    }

    void DestroyWall(GameObject wall)
    {

        Destroy(wall);
    }
    
}

