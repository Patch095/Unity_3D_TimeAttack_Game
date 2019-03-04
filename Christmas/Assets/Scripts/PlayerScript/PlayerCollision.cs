using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public ScoreMngEx scoreMng;
    public PowerUpManager powerUps;
    float defaultTimer;

    public void Start()
    {
        defaultTimer = powerUps.defaultTimer;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gift")
        {
            scoreMng.AddScore();
        }
        if (other.tag == "Blue")
            powerUps.timers[0] = defaultTimer;
        else if (other.tag == "Red")
            powerUps.timers[1] = defaultTimer;
        else if (other.tag == "Green")
            powerUps.timers[2] = defaultTimer;
    }
}
