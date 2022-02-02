using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public void Update()
    {
        HandleMovement();
    }

    public void HandleMovement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement * speed * Time.deltaTime, 0, verticalMovement * speed * Time.deltaTime);
        transform.Translate(movement);
    }
}