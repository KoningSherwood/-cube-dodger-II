using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Cube Statistics

    //Other

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Collided(collision);
        }
    }

    public virtual void Collided(Collision collision)
    {
        Destroy(gameObject);

        Debug.Log("Cube Not Dodged");
    }
}
