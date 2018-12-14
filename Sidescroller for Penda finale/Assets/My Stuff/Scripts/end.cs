using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{

   
    // Use this for initialization
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
           
        }
    }
}

