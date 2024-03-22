using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 10;
    private Cheat gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Cheat").GetComponent<Cheat>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            Debug.Log("Game Over");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        else if (transform.position.x < -sideBound)
        {
            Debug.Log("Game Over");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
