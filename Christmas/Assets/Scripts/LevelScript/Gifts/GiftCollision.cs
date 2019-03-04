using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftCollision : MonoBehaviour
{
    public bool IsColliding;

    private void OnEnable()
    {
        IsColliding = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        IsColliding = true;
        Debug.Log("Score +100");
    }
    private void OnTriggerEnter(Collider other)
    {
        IsColliding = true;
        Debug.Log("Score +100");
    }
}
