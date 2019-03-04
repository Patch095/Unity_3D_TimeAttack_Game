using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpingPlatform : MonoBehaviour
{
    public GameObject Active;
    public GameObject NotActive;
    public bool IsActive;

	// Update is called once per frame
	void Update ()
    {
        Active.SetActive(IsActive);
        NotActive.SetActive(!IsActive);
	}
}
