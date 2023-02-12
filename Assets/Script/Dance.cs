using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
    Material mat;
    float exitTime = 1f;
    public bool isDancing = false;
    bool isWaitingExit = false;
    float time;
    Animator animator;
    

    void Awake()
    {
        mat = this.GetComponent<Renderer>().material;
        animator = this.GetComponent<Animator>();
        
    }
    void FixedUpdate()
    {
        if(isWaitingExit)
            if(Time.time - time >= exitTime)
                ExitDance();
    }

    public void GetDance(GameObject owner)
    {
        isDancing = true;
        isWaitingExit = false;

        mat.SetColor("_EmissionColor",Color.green);
        print("dance");
    }

    public void WarnExitDance()
    {
        time = Time.time;
        isWaitingExit = true;
        isDancing = false;
        print("warn");
    }

    void ExitDance()
    {
         isWaitingExit = false;
         
         mat.SetColor("_EmissionColor",Color.red);
         print("exit");
    }
}
