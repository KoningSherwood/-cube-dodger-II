using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : Cube
{
    public override void Collided(Collision collision)
    {
        Debug.Log("Upgraded!");
    }
}
