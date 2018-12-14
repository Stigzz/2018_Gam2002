using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroy2 : MonoBehaviour
{

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("timer");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }
}


