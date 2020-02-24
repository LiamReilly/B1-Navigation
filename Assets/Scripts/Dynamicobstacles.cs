using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamicobstacles : MonoBehaviour
{
    Vector3 begin;
    Vector3 end;
    bool returning;
    float count;

    private void Start()
    {
        count = 2f;
        returning = true;
        /*begin = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        end = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z+5);*/
    }


    void Update()
    {
        count -= Time.deltaTime;
        if (count <= 0)
        {
            returning = !returning;
            count = 2;
        }

        if(returning)
        {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
        else
        {
            gameObject.transform.Translate(-Vector3.forward * Time.deltaTime * 5);
        }
    }
}
