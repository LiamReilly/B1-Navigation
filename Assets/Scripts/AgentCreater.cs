using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCreater : MonoBehaviour
{
    public static HashSet<GameObject> CreatedAgents = new HashSet<GameObject>();
    public float radius;
    public GameObject agent;
    public int agentCount;
    Vector3 location;
    GameObject Selectionmanager;
    public Material SelectedColor;
    private int Count;


    // Start is called before the first frame update
    void Start()
    {
        Selectionmanager = GameObject.Find("Main Camera");
        Count = 0;
        radius = radius * 2;
        var agParent = GameObject.Find("AgentCreator");

        while (Count < agentCount)
        {
            location = new Vector3((Random.value-0.5f) * radius, 0.5f, (Random.value-0.5f) * radius);
            var newAgent = Instantiate(agent, location, Quaternion.identity);

            //var a = newAgent.GetComponent<Rigidbody>();
            //a.AddForce(100,0,0);
            
            //newAgent.transform.position = new Vector3((Random.value - 0.5f) * radius, 0.5f, ((Random.value - 0.5f)) * radius);
            newAgent.name = "a" + Count;
            newAgent.transform.parent = agParent.transform;
            CreatedAgents.Add(newAgent);
            Count++;
        }
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
    public void addAgent()
    {

        var agParent = GameObject.Find("AgentCreator");
        var newcount = Count + 5;
        while (Count < newcount)
        {
            location = new Vector3((Random.value - 0.5f) * radius, 0.5f, (Random.value - 0.5f) * radius);
            var newAgent = Instantiate(agent, location, Quaternion.identity);
            newAgent.name = "a" + Count;
            newAgent.transform.parent = agParent.transform;
            CreatedAgents.Add(newAgent);
            Count++;
        }
    }
    public void SelectAll()
    {
        foreach (var item in CreatedAgents)
        {
            MeshRenderer gameObjectRenderer = item.gameObject.GetComponent<MeshRenderer>();
            gameObjectRenderer.material = SelectedColor;
            Selectionmanager.gameObject.GetComponent<ObjectSelection>().GroupAgents.Add(item);
        }
    }
}
