using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WarpManager : MonoBehaviour
{
    public Transform[] warpingZone;
    public Transform ActivePlatform { get { return warpingZone[activeWarpPlatformIndex]; } }
    public GameObject player;
    NavMeshAgent agent;
    float timer;
    public int activeWarpPlatformIndex;
    public ScoreMngEx scoreMng;

    void Start ()
    {
        PlatformActivation();
        agent = player.GetComponent<NavMeshAgent>();
    }

    void Update ()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            ActivePlatform.GetComponent<WarpingPlatform>().IsActive = false;
            PlatformActivation();
        }
	}

    void PlatformActivation()
    {
        activeWarpPlatformIndex = Random.Range(0, warpingZone.Length);
        ActivePlatform.GetComponent<WarpingPlatform>().IsActive = true;
        timer = Random.Range(3, 6);
    }

    public void WarpPlayer()
    {
        agent.Warp(ActivePlatform.position);
        scoreMng.TimeValue -= 10;
    }
}
