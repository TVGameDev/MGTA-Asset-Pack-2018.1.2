using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
	}

}
