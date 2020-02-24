﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObjectSelection : MonoBehaviour
{
    public static HashSet<GameObject> GroupAgents = new HashSet<GameObject>();
    public Material SelectedColor;
    public Material DeselectedColor;
    public static HashSet<GameObject> moveableObstacles = new HashSet<GameObject>();
    public GameObject errorSphere;
    bool objectsMoveable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;

            RaycastHit[] hits = Physics.RaycastAll(ray);

            Debug.Log(hits.Length);

            if(hits.Length == 0)
            {
                return;
            }
            
            Vector3 dest = new Vector3(0,0,0);

            foreach(RaycastHit hit in hits)
            {
                if(hit.transform.tag == "Floor")
                {
                    dest = hit.point;
                }
                else
                    if(hit.transform.tag == "Agent")
                    {
                        if(GroupAgents.Contains(hit.transform.gameObject))
                        {
                            MeshRenderer gameObjectRenderer = hit.transform.gameObject.GetComponent<MeshRenderer>();
                            gameObjectRenderer.material = DeselectedColor;
                            GroupAgents.Remove(hit.transform.gameObject);
                            hit.transform.gameObject.GetComponent<SetTarger>().SetDestination(hit.transform.position);
                    }
                        else
                        {
                            MeshRenderer gameObjectRenderer = hit.transform.gameObject.GetComponent<MeshRenderer>();
                            gameObjectRenderer.material = SelectedColor;
                            GroupAgents.Add(hit.transform.gameObject);
                        }
                        return;
                    }
                if (hit.transform.tag == "moveObstacle")
                {
                   if(moveableObstacles.Contains(hit.transform.gameObject))
                    {
                        MeshRenderer gameObjectRenderer = hit.transform.gameObject.GetComponent<MeshRenderer>();
                        gameObjectRenderer.material = DeselectedColor;
                        moveableObstacles.Remove(hit.transform.gameObject);
                    }
                    else
                    {
                        MeshRenderer gameObjectRenderer = hit.transform.gameObject.GetComponent<MeshRenderer>();
                        gameObjectRenderer.material = SelectedColor;
                        moveableObstacles.Add(hit.transform.gameObject);
                        objectsMoveable = true;
                    }
                }
            }

            foreach (var item in GroupAgents)
            {
                item.transform.gameObject.GetComponent<SetTarger>().SetDestination(dest);
            }

            /*
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawRay(transform.position, ray.direction * hit.distance, Color.yellow);

                Vector3 desiredLoc = hit.point;

                 
                //var sphere = Instantiate(errorSphere, desiredLoc, Quaternion.identity);

                Debug.Log(desiredLoc);
                Debug.Log(hit.transform.tag);

                if (hit.transform.tag == "Agent")
                {
                    Debug.Log(GroupAgents.Count);

                     if (GroupAgents.Contains(hit.transform.gameObject))
                     {
                        MeshRenderer gameObjectRenderer = hit.transform.gameObject.GetComponent<MeshRenderer>();
                        gameObjectRenderer.material = DeselectedColor;
                        GroupAgents.Remove(hit.transform.gameObject);

                     }
                     else
                     {
                        MeshRenderer gameObjectRenderer = hit.transform.gameObject.GetComponent<MeshRenderer>();
                        gameObjectRenderer.material = SelectedColor;
                        GroupAgents.Add(hit.transform.gameObject);
                     }
                }
                else if (hit.transform.tag == "Floor")
                {
                    //agentFab.SetDestination(desiredLoc);
                   // if (Camera.main.gameObject.GetComponent<ObjectSelection>().IsInList(gameObject))
                    //{

                        //var sphere = Instantiate(errorSphere, desiredLoc, Quaternion.identity);

                        foreach (var item in GroupAgents)
                        {
                            item.transform.gameObject.GetComponent<SetTarger>().SetDestination(hit.point);
                        }
                        
                   // }
                }
                //Destroy(hit.transform.gameObject);
            }
            // */
        }
        if(objectsMoveable == true)
        {
            foreach (var item in moveableObstacles)
            {
                if((Input.GetKey(KeyCode.UpArrow)))
                item.transform.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 25);
                if ((Input.GetKey(KeyCode.DownArrow)))
                    item.transform.gameObject.transform.Translate(-Vector3.forward * Time.deltaTime * 25);
                if ((Input.GetKey(KeyCode.LeftArrow)))
                    item.transform.gameObject.transform.Translate(Vector3.left * Time.deltaTime * 25);
                if ((Input.GetKey(KeyCode.RightArrow)))
                    item.transform.gameObject.transform.Translate(Vector3.right * Time.deltaTime*25);
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
    