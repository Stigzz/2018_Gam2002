using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

    public int num;

	// Use this for initialization
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("esr");
            Debug.Log("Scene changed to " + num);
        }
  	}
}

