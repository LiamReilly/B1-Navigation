using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetTarger : MonoBehaviour
{
    /*

    public GameObject ObjectSelect;
    GameObject desiredLoc;
    GameObject mainCamera;
    Vector3 desiredLoc;
    Camera cam;
    public bool Active;
    public static HashSet<GameObject> GroupAgents = new HashSet<GameObject>();
    // */

    
    NavMeshAgent agentFab;

    // Start is called before the first frame update
    void Start()
    {

        agentFab = GetComponent<NavMeshAgent>();


        /*
        desiredLoc = GameObject.Find("Target(Clone)");
        mainCamera = GameObject.Find("Main Camera");
        agentFab.SetDestination(gameObject.transform.position);
        cam = mainCamera.GetComponent<Camera>();
        agentFab.SetDestination(gameObject.transform.position);
        // */
    }
    /*
    // Update is called once per frame
    void Update()
    {
        //if()
        //agentFab.SetDestination(desiredLoc.transform.position);
        //loc = new Vector3(0f, 0.5f, 0f);
        //agentFab.SetDestination(loc);
        //agent.SetDestination(ObjectSelect.gameObject.GetComponent<ObjectSelection>().desiredLoc);
        /* if (Input.GetMouseButtonDown(0))
        {
            RaycastOnClick();

                if (hit.transform.tag == "Agent")
                {
                    if (GroupAgents.Contains(hit.transform.gameObject))
                     { 
                         GroupAgents.Remove(hit.transform.gameObject);
                     }
                     if (!GroupAgents.Contains(hit.transform.gameObject))
                     {
                         GroupAgents.Add(hit.transform.gameObject);
                     }
            }
        //Destroy(hit.transform.gameObject);
    }

    void RaycastOnClick()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            Vector3 desiredLoc = hit.point;
            Debug.Log(desiredLoc);
            if (hit.transform.tag == "Floor")
            {
                //agentFab.SetDestination(desiredLoc);
                if (mainCamera.gameObject.GetComponent<ObjectSelection>().IsInList(gameObject))
                {
                    agentFab.SetDestination(desiredLoc);
                }
            }
        }
    }*/

    public void SetDestination(Vector3 destination)
    {
        
            agentFab.SetDestination(destination);
    }
}





