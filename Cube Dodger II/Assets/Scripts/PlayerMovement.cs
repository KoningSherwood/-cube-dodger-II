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
        //float verticalMovement = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(horizontalMovement * speed * Time.deltaTime, jump * speed * Time.deltaTime, speed * Time.deltaTime);
        transform.Translate(movement);
    }
}