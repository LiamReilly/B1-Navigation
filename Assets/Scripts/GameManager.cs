using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject Creatormanager;
    private GameObject SelectButton;
    private GameObject DeselectButton;
    private AudioSource source1;

    // Start is called before the first frame update
    void Start()
    {
        Creatormanager = GameObject.Find("AgentCreator");
        SelectButton = GameObject.Find("SelectAll");
        DeselectButton = GameObject.Find("DeselectAll");
        DeselectButton.gameObject.SetActive(false);
        source1 = GetComponent<AudioSource>();

    }

    /*
    void Update()
    {
        
    }
    */
    public void add5Agents()
    {
        source1.Play();
        Creatormanager.gameObject.GetComponent<AgentCreater>().addAgent();
    }
    public void SelectAll()
    {
        source1.Play();
        Creatormanager.gameObject.GetComponent<AgentCreater>().SelectAll();
        SelectButton.gameObject.SetActive(false);
        DeselectButton.gameObject.SetActive(true);

    }
    public void DeselectAll()
    {
        source1.Play();
        Creatormanager.gameObject.GetComponent<AgentCreater>().DeselectAll();
        SelectButton.gameObject.SetActive(true);
        DeselectButton.gameObject.SetActive(false);

    }
}
