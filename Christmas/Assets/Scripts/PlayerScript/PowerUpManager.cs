using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PowerUpManager : MonoBehaviour
{
    NavMeshAgent agent;
    public WarpManager wp;

    public GameObject[] shields;//water, fire, aoe
    bool[] activeted;//water, fire, aoe
    public float[] timers;
    public float defaultTimer = 4f;

    public Transform Terrain;
    RaycastHit hitInfo;

	// Use this for initialization
	void Start ()
    {
        activeted = new bool[shields.Length];
        timers = new float[shields.Length];
        agent = GetComponent<NavMeshAgent>();
	}

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < shields.Length; i++)
        {
            timers[i] -= Time.deltaTime;
            if (timers[i] > 0)
                activeted[i] = true;
            else
                activeted[i] = false;

            shields[i].SetActive(activeted[i]);
        }

        TerrainCheck();
        switch (Terrain.name)
        {
            case "Water":
                if (!shields[0].active)
                {
                    wp.WarpPlayer();
                }
                break;
            case "Fire":
                if (!shields[1].active)
                {
                    wp.WarpPlayer();
                }
                break;
            default:
                break;
        }
    }

    void TerrainCheck()
    {
        Ray ray = new Ray(this.transform.position, -transform.up);
        if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        {
            Terrain = hitInfo.transform;
        }
    }
}