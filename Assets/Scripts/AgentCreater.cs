using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCreater : MonoBehaviour
{
    public float radius;
    public GameObject agent;
    public int agentCount;
    Vector3 location;
     
    
    // Start is called before the first frame update
    void Start()
    {
        var Count = 0;
        radius = radius * 2;
        var agParent = GameObject.Find("AgentCreator");
        while (Count < agentCount)
        {
            location = new Vector3((Random.value-0.5f) * radius, 0.5f, (Random.value-0.5f) * radius);
            var newAgent = Instantiate(agent, location, Quaternion.identity);
            
            //newAgent.transform.position = new Vector3((Random.value - 0.5f) * radius, 0.5f, ((Random.value - 0.5f)) * radius);
            newAgent.name = "a" + Count;
            newAgent.transform.parent = agParent.transform;
            
            Count++;
        }
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
}
