using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float distanseDelete = 15f;

    void Update()
    {
        if(transform.position.x > 15)
        {
            Destroy(this.gameObject);
        }
    }
}
