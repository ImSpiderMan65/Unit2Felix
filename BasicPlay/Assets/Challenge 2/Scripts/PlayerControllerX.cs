using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnCooldown = 1.0f;

    private void Start()
    {
        spawnCooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnCooldown = spawnCooldown - Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (spawnCooldown > 0)
            {
                return;
            }

            if (spawnCooldown <= 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spawnCooldown = 1;
            }
        }
    }

   
}
