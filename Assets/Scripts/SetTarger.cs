using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetTarger : MonoBehaviour
{

    //public GameObject ObjectSelect;

    GameObject desiredLoc;
    NavMeshAgent agentFab;
    
    // Start is called before the first frame update
    void Start()
    {

        desiredLoc = GameObject.Find("Target(Clone)");
        agentFab = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        agentFab.SetDestination(desiredLoc.transform.position);
        //loc = new Vector3(0f, 0.5f, 0f);
        //agentFab.SetDestination(loc);
        //agent.SetDestination(ObjectSelect.gameObject.GetComponent<ObjectSelection>().desiredLoc);
    }
    
}
