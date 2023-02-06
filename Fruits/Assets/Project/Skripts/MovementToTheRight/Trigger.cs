using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using UnityEngine;
public class Trigger : MonoBehaviour
{
    public GameObject fruitObjects;
    //public ParticleSystem explosionParticle;

    private Vector3 target;

    private void OnMouseDown()
    {
        
        if (gameObject.CompareTag("apple"))
        {
            Debug.Log(" Актив " + TextApp.active);
            for (int i = 0; i < 4; i++)
            {
                if (RandomFruits.fruitRandAndKil[i, 0] == 1)
                {
                    if (RandomFruits.fruitRandAndKil[i, 1] > 0)
                    {
                        RandomFruits.fruitRandAndKil[i, 1] -= 1;
                        Destroy(this.gameObject);
                        Vector3 target = new Vector3(RandomFruits.vectorX, 6.88f, RandomFruits.vectorZ);
                        Instantiate(fruitObjects, target, this.transform.rotation);
                        //explosionParticle.Play();
                        TextApp.active = true;
                    }

                    break;
                }
            }
        }
        if (gameObject.CompareTag("avocado"))
        {
            Debug.Log(" Актив " + TextApp.active);
            for (int i = 0; i < 4; i++)
            {

                if (RandomFruits.fruitRandAndKil[i, 0] == 2)
                {
                    if (RandomFruits.fruitRandAndKil[i, 1] > 0)
                    {
                        RandomFruits.fruitRandAndKil[i, 1] -= 1;
                        Destroy(this.gameObject);
                        Vector3 target = new Vector3(RandomFruits.vectorX, 6.88f, RandomFruits.vectorZ);
                        Instantiate(fruitObjects, target, this.transform.rotation);
                        TextApp.active = true;
                    }
                    break;
                }
            }
        }
        if (gameObject.CompareTag("banana"))
        {
            Debug.Log(" Актив " + TextApp.active);
            for (int i = 0; i < 4; i++)
            {

                if (RandomFruits.fruitRandAndKil[i, 0] == 3)
                {
                    if (RandomFruits.fruitRandAndKil[i, 1] > 0)
                    {
                        RandomFruits.fruitRandAndKil[i, 1] -= 1;
                        Destroy(this.gameObject);
                        Vector3 target = new Vector3(RandomFruits.vectorX, 6.88f, RandomFruits.vectorZ);
                        Instantiate(fruitObjects, target, this.transform.rotation);
                        TextApp.active = true;
                    }
                    break;
                }
            }
        }
        if (gameObject.CompareTag("cherries"))
        {
            Debug.Log(" Актив " + TextApp.active);
            for (int i = 0; i < 4; i++)
            {

                if (RandomFruits.fruitRandAndKil[i, 0] == 4)
                {
                    if (RandomFruits.fruitRandAndKil[i, 1] > 0)
                    {
                        RandomFruits.fruitRandAndKil[i, 1] -= 1;
                        Destroy(this.gameObject);
                        Vector3 target = new Vector3(RandomFruits.vectorX, 6.88f, RandomFruits.vectorZ);
                        Instantiate(fruitObjects, target, this.transform.rotation);
                        TextApp.active = true;
                    }
                    break;
                }
            }
        }
        if (gameObject.CompareTag("lemon"))
        {
            Debug.Log(" Актив " + TextApp.active);
            for (int i = 0; i < 4; i++)
            {

                if (RandomFruits.fruitRandAndKil[i, 0] == 5)
                {
                    if (RandomFruits.fruitRandAndKil[i, 1] > 0)
                    {
                        RandomFruits.fruitRandAndKil[i, 1] -= 1;
                        Destroy(this.gameObject);
                        Vector3 target = new Vector3(RandomFruits.vectorX, 6.88f, RandomFruits.vectorZ);
                        Instantiate(fruitObjects, target, this.transform.rotation);
                        TextApp.active = true;
                    }
                    break;
                }
            }
        }
        if (gameObject.CompareTag("strawberry"))
        {
            Debug.Log(" Актив " + TextApp.active);
            for (int i = 0; i < 4; i++)
            {

                if (RandomFruits.fruitRandAndKil[i, 0] == 6)
                {
                    if (RandomFruits.fruitRandAndKil[i, 1] > 0)
                    {
                        RandomFruits.fruitRandAndKil[i, 1] -= 1;
                        Destroy(this.gameObject);
                        Vector3 target = new Vector3(RandomFruits.vectorX, 6.88f, RandomFruits.vectorZ);
                        Instantiate(fruitObjects, target, this.transform.rotation);
                        TextApp.active = true;
                    }
                    break;
                }
            }
        }
    }
}
