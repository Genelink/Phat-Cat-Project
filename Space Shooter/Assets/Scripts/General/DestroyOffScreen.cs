using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    //private Vector2 ScreenBounds;
    // Start is called before the first frame update
    void Start()
    {
        //ScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        /*if(transform.position.x < ScreenBounds.x * 5)
        {
            Destroy(this.gameObject);
        }*/
    }

    public void Kill()
    {
        Debug.Log("Deleted");
        Destroy(this.gameObject);
        
    }
}
