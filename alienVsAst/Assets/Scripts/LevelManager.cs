using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Load Scenes
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        //currentIndex + 1
       // SceneManager.LoadScene(currentIndex + 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
