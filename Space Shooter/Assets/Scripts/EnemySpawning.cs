using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{

    public GameObject Enemy1;
    public GameObject Rock1;
    public float RespawnTime;
    private Vector2 ScreenBounds;


    // Start is called before the first frame update
    void Start()
    {
        ScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(WaspRockRespawn());
    }

    private void SpawnEnemy()
    {
        GameObject WaspRock = Instantiate(Enemy1) as GameObject;
        WaspRock.transform.position = new Vector2(ScreenBounds.x * 2, Random.Range(-ScreenBounds.y, ScreenBounds.y));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaspRockRespawn()
    {
        while(true){
            yield return new WaitForSeconds(RespawnTime);
            SpawnEnemy();
        }
    }



}
