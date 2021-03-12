using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public Transform[] spawnObject;
    public GameObject Enemy;
    public float TimeSpawn = 2f;
    private float Timering = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timering += Time.deltaTime;
        if(Timering <= TimeSpawn)
        {
            Timering = 0;
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        int luck = Random.Range(0, spawnObject.Length - 1);
        Instantiate(Enemy, spawnObject[luck].position, transform.rotation);
    }
}
