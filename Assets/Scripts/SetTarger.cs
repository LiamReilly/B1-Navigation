using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetTarger : MonoBehaviour
{

    //public GameObject ObjectSelect;

    //GameObject desiredLoc;
    NavMeshAgent agentFab;
    GameObject mainCamera;
    Vector3 desiredLoc;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {

        //desiredLoc = GameObject.Find("Target(Clone)");
        mainCamera = GameObject.Find("Main Camera");
        agentFab = GetComponent<NavMeshAgent>();
        agentFab.SetDestination(gameObject.transform.position);
        cam = mainCamera.GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        //if()
        //agentFab.SetDestination(desiredLoc.transform.position);
        //loc = new Vector3(0f, 0.5f, 0f);
        //agentFab.SetDestination(loc);
        //agent.SetDestination(ObjectSelect.gameObject.GetComponent<ObjectSelection>().desiredLoc);
        if (Input.GetMouseButtonDown(0))
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
                    agentFab.SetDestination(desiredLoc);
                }
                //Destroy(hit.transform.gameObject);
            }
        }
    }
    
}
