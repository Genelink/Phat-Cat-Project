using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public GameObject firePoint;
    public float bulletSpeed;
    public float BulletReloadSpd;
    private bool isCoroutineExecuting = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") & isCoroutineExecuting == false)
        {
            GameObject b = Instantiate(bullet, firePoint.transform.position, Quaternion.identity);
            b.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0);
            Debug.Log("click");
            StartCoroutine(ExecuteAfterTime(BulletReloadSpd));
            
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
     if (isCoroutineExecuting)
         yield break;
 
     isCoroutineExecuting = true;
 
     yield return new WaitForSeconds(time);
  
     // Code to execute after the delay
 
     isCoroutineExecuting = false;
    }

}
