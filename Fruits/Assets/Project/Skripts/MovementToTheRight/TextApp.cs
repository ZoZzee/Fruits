using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextApp : MonoBehaviour
{
    public float speed = 4;

    public static bool active = false;

    private Vector3 transformPos;
    private Vector3 posStart = new Vector3(0,0,0);


    private float time;

    void Start()
    {
        time = 3.5f;
        transformPos = this.transform.position;
    }

    void Update()
    {
        if( active == true )
        {
            if(time == 3.5f)
            {
                transform.position = transformPos;
            }
            time -= Time.deltaTime;
            if(time > 0)
            {
                
                this.transform.Translate(this.transform.up * speed * Time.deltaTime);
            }
            if(time <= 0)
            {
                time = 3.5f;
                active= false;
            }
        }
        else
        {
            transform.position= posStart;
        }
        
    }
}
