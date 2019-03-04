using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCollision : MonoBehaviour
{
    public bool IsColliding;
    public int index;

    private void OnEnable()
    {
        IsColliding = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsColliding = true;
        Debug.Log("PowerUp");
    }
    private void OnTriggerEnter(Collider other)
    {
        IsColliding = true;
        Debug.Log("PowerUp");
    }
}
