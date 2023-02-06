using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTheRight : MonoBehaviour
{
    private float speed;

    void Update()
    {
        speed = SpawnPoint.speed;
        transform.Translate(new Vector3(1,0,0) * speed * Time.deltaTime);
    }
}
