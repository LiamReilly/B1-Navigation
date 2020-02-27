using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCreater : MonoBehaviour
{
    public float radius;
    public GameObject agent;
    public static int agentCount = 30;
    Vector3 location;
     
    
    // Start is called before the first frame update
    void Start()
    {
        radius = radius * 2;
        var agParent = GameObject.Find("AgentCreator");

        for (int i = 0; i < agentCount; i++)
        {
            location = new Vector3((Random.value-0.5f) * radius, 0.5f, (Random.value-0.5f) * radius);
            var newAgent = Instantiate(agent, location, Quaternion.identity);

            //var a = newAgent.GetComponent<Rigidbody>();
            //a.AddForce(100,0,0);
            
            //newAgent.transform.position = new Vector3((Random.value - 0.5f) * radius, 0.5f, ((Random.value - 0.5f)) * radius);
            newAgent.name = "a" + i;
            newAgent.transform.parent = agParent.transform;
        }
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
}
