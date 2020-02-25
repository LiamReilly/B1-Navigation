using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject Creatormanager;
    
    // Start is called before the first frame update
    void Start()
    {
        Creatormanager = GameObject.Find("AgentCreator");
        
    }

    /*
    void Update()
    {
        
    }
    */
    public void add5Agents()
    {
        Creatormanager.gameObject.GetComponent<AgentCreater>().addAgent();
    }
    public void SelectAll()
    {
        Creatormanager.gameObject.GetComponent<AgentCreater>().SelectAll();
    }
}
