using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObjectSelection : MonoBehaviour
{
    public static HashSet<GameObject> GroupAgents = new HashSet<GameObject>();
    public Material SelectedColor;
    public Material DeselectedColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

                Vector3 desiredLoc = hit.point;
                Debug.Log(desiredLoc);
                Debug.Log(hit.transform.tag);
                if (hit.transform.tag == "Agent")
                {
                     if (GroupAgents.Contains(hit.transform.gameObject))
                     {
                        MeshRenderer gameObjectRenderer = hit.transform.gameObject.GetComponent<MeshRenderer>();
                        gameObjectRenderer.material = DeselectedColor;
                        GroupAgents.Remove(hit.transform.gameObject);

                     }
                     if (!GroupAgents.Contains(hit.transform.gameObject))
                     {
                        MeshRenderer gameObjectRenderer = hit.transform.gameObject.GetComponent<MeshRenderer>();
                        gameObjectRenderer.material = SelectedColor;
                        GroupAgents.Add(hit.transform.gameObject);
                     }
                }
                if (hit.transform.tag == "Floor")
                {
                    //agentFab.SetDestination(desiredLoc);
                   // if (Camera.main.gameObject.GetComponent<ObjectSelection>().IsInList(gameObject))
                    //{
                        foreach (var item in GroupAgents)
                        {
                            item.transform.gameObject.GetComponent<SetTarger>().SetDestination(hit.point);
                        }
                        
                   // }
                }
                //Destroy(hit.transform.gameObject);
            }
        }
    }
    public bool IsInList(GameObject agent)
    {
        if (GroupAgents.Contains(agent.transform.gameObject))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
    