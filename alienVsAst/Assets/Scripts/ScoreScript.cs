using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public int score;


    void Awake()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        print("Hit the enemy");
    }
}
