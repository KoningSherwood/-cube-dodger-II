using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : Cube
{
    public override void Collided(Collision collision)
    {
        Debug.Log("Finished!");
    }
}
