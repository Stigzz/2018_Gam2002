﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyCubes : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            Destroy(col.gameObject);
        }

    }
}