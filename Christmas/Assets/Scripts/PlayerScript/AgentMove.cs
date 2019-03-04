using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentMove : MonoBehaviour
{
    NavMeshAgent agent;

    public float speedT;
    public float speedR;
    public string HAxisName = "Horizontal";
    public string VAxisName = "Vertical";

	// Use this for initialization
	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		float HVal = Input.GetAxis(HAxisName) * speedR * Time.deltaTime;
        float VVal = Input.GetAxis(VAxisName) * speedT * Time.deltaTime;

        agent.velocity = new Vector3(HVal, 0, VVal) * agent.speed;
    }
}