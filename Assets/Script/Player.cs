using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //List<GameObject> npcs;

    void Awake()
    {
        //npcs = new();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "npc")
        GetDance(other);
    }

    void GetDance(Collider other)
    {
        var dance = other.GetComponent<Dance>();

        if(dance.isDancing == false) // 以是否正在跳舞作為是否已在list內的判斷
        {
            dance.GetDance();
            //npcs.Add(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "npc")
            ExitDance(other);
    }

    void ExitDance(Collider other)
    {
        var dance = other.GetComponent<Dance>();

        if(dance.isDancing)
        dance.WarnExitDance();
    }


}
