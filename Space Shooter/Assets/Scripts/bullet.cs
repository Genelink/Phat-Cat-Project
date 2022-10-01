using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(this.gameObject);
        }
        if (other.tag == "Rock")
        {
            Destroy(this.gameObject);
        }
    }
}
