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
    private GameObject MC;
    private bool VideoOn;
    public Material kapadia;
    public Material grass;
    private GameObject Room1;

    // Start is called before the first frame update
    void Start()
    {
        Creatormanager = GameObject.Find("AgentCreator");
        SelectButton = GameObject.Find("SelectAll");
        DeselectButton = GameObject.Find("DeselectAll");
        DeselectButton.gameObject.SetActive(false);
        source1 = GetComponent<AudioSource>();
        MC = GameObject.Find("Main Camera");
        VideoOn = false;
        Room1 = GameObject.Find("Room1");

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
    public void CreateAdversary()
    {
        source1.Play();
        Creatormanager.gameObject.GetComponent<AgentCreater>().CreateAdversary();
    }
    public void GSC()
    {
        source1.Play();
        if (!VideoOn)
        {
            MC.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            VideoOn = true;
            MeshRenderer gameObjectRenderer = Room1.gameObject.GetComponent<MeshRenderer>();
            gameObjectRenderer.material = kapadia;
        }

        else
        {
            MC.GetComponent<UnityEngine.Video.VideoPlayer>().Stop();
            VideoOn = false;
            MeshRenderer gameObjectRenderer = Room1.gameObject.GetComponent<MeshRenderer>();
            gameObjectRenderer.material = grass;
        }
    }
}
