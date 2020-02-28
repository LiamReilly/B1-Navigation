using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
    private AudioSource dubberz;
    private bool once = false;
    
    // Start is called before the first frame update
    void Start()
    {
        dubberz = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!once)
        {
            dubberz.Play();
            once = true;
        }
        
    }

}
