using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionScript : MonoBehaviour {
    public Text scoreTxt;
    int score = 0;
	// Use this for initialization
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    

    void OnTriggerEnter(Collider col)
    {
        score++;
        print("score is:" + score);

        switch(col.tag)
        {
            case "player1": print("hit the enemy1!");
                score++;
                break;
            case "player2":
                print("hit the enemy2!");
                score++;
                break;
            case "player3":
                print("hit the enemy3!");
                score++;
                break;
            case "player4":
                print("hit the enemy4!");
                score++;
                break;

        }

        GameObject explosion = Instantiate(Resources.Load("FlareMobile", typeof(GameObject))) as GameObject;
        explosion.transform.position = transform.position;
        Destroy(col.gameObject);
        Destroy(explosion, 1);

      


        if (GameObject.FindGameObjectsWithTag("player1").Length == 0) //this is going to restart the aliens
        {
            GameObject enemy = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;

        }
        if (GameObject.FindGameObjectsWithTag("player2").Length == 0) //this is going to restart the aliens
        {
            GameObject enemy1 = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
        }

        if (GameObject.FindGameObjectsWithTag("player3").Length == 0) //this is going to restart the aliens
        {

            GameObject enemy2 = Instantiate(Resources.Load("enemy2", typeof(GameObject))) as GameObject;
        }
        if (GameObject.FindGameObjectsWithTag("player4").Length == 0) //this is going to restart the aliens
        {
            GameObject enemy3 = Instantiate(Resources.Load("enemy3", typeof(GameObject))) as GameObject;
        }


        Destroy(gameObject);//destroy the game object that is the bullet

        
    }

   
}
