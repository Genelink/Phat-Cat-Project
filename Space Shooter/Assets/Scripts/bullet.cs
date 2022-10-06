using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject[] Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bulletDestroyer")
        {
            Destroy(this.gameObject);
        }
        if ( other.tag == "enemy")
        {
            other.GetComponent <enemy> ().Kill();
            foreach (GameObject x in Player)
            {
                x.GetComponent<Score>().CurrentScore += 10;
            }
            //Player[].GetComponent<Score>().CurrentScore += 10;
            
            Destroy(this.gameObject);
        }
        if (other.tag == "Rock")
        {
            Destroy(this.gameObject);
        }
    }
}
