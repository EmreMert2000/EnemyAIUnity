using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
     private Transform hedef;

    // Start is called before the first frame update
    void Start()
    {
        
        navMeshAgent = GetComponent<NavMeshAgent>();
        hedef = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(hedef);
        navMeshAgent.SetDestination(hedef.position);
    }
}
