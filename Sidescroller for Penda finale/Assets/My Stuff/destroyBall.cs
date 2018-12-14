using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBall : MonoBehaviour {



    private void OnTriggerEnter2D (Collider2D ball)
    {
        print("Ferdi");
            Destroy(gameObject);
    }
}
