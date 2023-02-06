using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator boyAnim;

    void Start()
    {
        boyAnim = GetComponent<Animator>();
    }


    void Update()
    {
        if(RandomFruits.finishGame == true)
        {
            boyAnim.SetBool("FinishGame", true);
        }
        if (RandomFruits.finishGame == false)
        {
            boyAnim.SetBool("FinishGame", false);
        }
    }
}
