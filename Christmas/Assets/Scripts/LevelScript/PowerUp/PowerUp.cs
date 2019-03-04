using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject[] balls;
    public GameObject gift;
    float changeTimer;
    float pauseTimer;
    int ActiveIndex;

    bool spawnGift;

    // Start is called before the first frame update
    void Start()
    {
        changeTimer = Random.RandomRange(3, 6);
        ActiveIndex = Random.RandomRange(0, balls.Length);
    }

    // Update is called once per frame
    void Update()
    {
        pauseTimer -= Time.deltaTime;
        if (pauseTimer < 0)
        {
            changeTimer -= Time.deltaTime;

            if (!spawnGift)
            {
                for (int i = 0; i < balls.Length; i++)
                {
                    if (i == ActiveIndex)
                        balls[i].active = true;
                    else
                        balls[i].active = false;
                }
                gift.active = false;

                bool isPowerUpColliding = balls[ActiveIndex].GetComponent<PowerUpCollision>().IsColliding;
                if (isPowerUpColliding)
                {
                    balls[ActiveIndex].active = false;
                    pauseTimer = Random.Range(5, 11);
                }
            }

            else if (spawnGift)
            {
                for (int i = 0; i < balls.Length; i++)
                {
                    balls[i].active = false;
                }
                gift.active = true;

                bool isGiftColliding = gift.GetComponent<GiftCollision>().IsColliding;
                if (isGiftColliding)
                {
                    gift.active = false;
                    pauseTimer = Random.Range(5, 11);
                }
            }

            if (changeTimer < 0)
            {
                int spawnGiftChance = Random.RandomRange(0, 100);
                if (spawnGiftChance % 13 == 0)
                    spawnGift = true;
                else
                    spawnGift = false;
                ActiveIndex = Random.RandomRange(0, balls.Length);
                changeTimer = Random.RandomRange(5, 11);
            }
        }
    }
}