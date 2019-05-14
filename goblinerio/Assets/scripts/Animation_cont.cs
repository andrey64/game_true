using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_cont : MonoBehaviour
{
    public Animation anim;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.A))
        {
            anim = GetComponent<Animation>();
            anim.Play("caracterRun");
        }
        else
        {
            anim.Stop("caracterRun");
        }
    }
}

