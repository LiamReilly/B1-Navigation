using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private int speed=3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime*speed);
        }
        if (Input.GetKey("s"))
        {
            gameObject.transform.Translate(Vector3.back * Time.deltaTime*speed);
        }
        if (Input.GetKey("a"))
        {
            gameObject.transform.Translate(-Vector3.right * Time.deltaTime*speed);
        }
        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime*speed);
        }
        if (Input.GetKey(KeyCode.LeftShift)|| Input.GetKey(KeyCode.RightShift))
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
}
