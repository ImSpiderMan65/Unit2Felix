using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Cheat : MonoBehaviour
{
    public int Score = 0;
    public int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }

    public void AddScore(int Value)
    {
        Score += Value;
        Debug.Log("Score = " + Score);
    } 
}
