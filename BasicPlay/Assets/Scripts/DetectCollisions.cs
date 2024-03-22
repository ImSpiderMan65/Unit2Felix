using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DetectCollisions : MonoBehaviour
{
    public int Score;
    private Cheat gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Cheat").GetComponent<Cheat>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
