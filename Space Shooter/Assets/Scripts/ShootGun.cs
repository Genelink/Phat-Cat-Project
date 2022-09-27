using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public GameObject firePoint;
    public float bulletSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject b = Instantiate(bullet, firePoint.transform.position, Quaternion.identity);
            b.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0);
            Debug.Log("click");
        }
    }
}
