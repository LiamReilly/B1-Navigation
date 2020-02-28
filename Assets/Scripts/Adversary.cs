using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Adversary : MonoBehaviour
{
    GameObject Area;
    NavMeshAgent agentFab;

    // Start is called before the first frame update
    void Start()
    {
        
        //Area = GameObject.Find("plane");
        agentFab = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Area.gameObject.transform.Translate(gameObject.transform.position);
        
    }
    public void SetDest(Vector3 destination)
    {
        agentFab.SetDestination(destination);
    }
}
