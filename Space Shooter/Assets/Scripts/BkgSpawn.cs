using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BkgSpawn : MonoBehaviour
{
    public GameObject NextBackground;
    public GameObject SpawnPoint;
    
    private bool ExitTrue = false;
    private bool isCoroutineExecuting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ExitTrue & isCoroutineExecuting == false)
        {
            Instantiate(NextBackground, SpawnPoint.transform.position, Quaternion.identity);
            ExitTrue = false;
            ExecuteAfterTime(2);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Instantiate(NextBackground, SpawnPoint.transform.position, Quaternion.identity);

        ExitTrue = true;
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