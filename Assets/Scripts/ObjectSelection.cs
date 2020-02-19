using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObjectSelection : MonoBehaviour
{
    
    Vector3 desiredLoc;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = Instantiate(target, Vector3.zero, Quaternion.identity);
        //target = GameObject.Find("Target (Clone)");
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
                if (hit.transform.tag == "Floor")
                {
                    target.transform.position = desiredLoc;
                }
                //Destroy(hit.transform.gameObject);
            }
        }
    }
    /*public Vector3 SendLoc()
    {
        return desiredLoc;
    }*/
}
