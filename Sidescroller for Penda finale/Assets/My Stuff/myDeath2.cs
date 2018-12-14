using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class myDeath2 : MonoBehaviour
{
    public GameObject Player;
    private bool runonces;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D deathCol)
    {
        if (deathCol.gameObject.tag == ("Player"))
        {
            GameObject destroyplayer = GameObject.FindGameObjectWithTag("Player");
            Destroy(destroyplayer);
            runonces = true;
            if (runonces)
            {
                SceneManager.LoadScene("esr2");
                runonces = false;

            }

        }
    }


}
