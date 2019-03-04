using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    public GameObject gift;
    float timer;
    bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        gift.active = isActive;

        if (isActive)
        {
            bool isGiftColliding = gift.GetComponent<GiftCollision>().IsColliding;
            if (isGiftColliding)
            {
                ResetTimer();
                isActive = false;
            }
        }

        if(timer < 0)
        {
            isActive = !isActive;
            ResetTimer();
        }
    }

    private void ResetTimer()
    {
        timer = Random.RandomRange(3, 9);
    }
}
