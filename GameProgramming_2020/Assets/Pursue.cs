using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pursue : MonoBehaviour
{
    private NavMeshAgent navAgent;

    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        navAgent.destination = goal.position;
    }
}
