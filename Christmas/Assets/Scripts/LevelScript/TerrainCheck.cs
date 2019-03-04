using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCheck : MonoBehaviour {

    public Transform Terrain;
    RaycastHit hitInfo;
	
	// Update is called once per frame
	void Update ()
    {
        Ray ray = new Ray(this.transform.position, -transform.up);
        if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        {
            Terrain = hitInfo.transform;
        }
    }
}
