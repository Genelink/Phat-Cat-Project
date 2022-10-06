using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameDeath : MonoBehaviour
{
    public GameObject LevelLoader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PauseGame()
    {
        LevelLoader.GetComponent<Levelloader>().LoadGameOver();
        //Time.timeScale = 0f;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            PauseGame();
            //Debug.Log("Detect");
        }

        if (other.tag == "Rock")
        {
            PauseGame();
            //Debug.Log("Detect");
        }
    }
}
