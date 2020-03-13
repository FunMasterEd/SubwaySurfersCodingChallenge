using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] tiles;
    public Vector3 offset;
    int tick = 0;
    void Start()
    {  

        
    }

    void Update()
    {
        tick--;
        if(tick < 0)
        {
            GameObject Level = (GameObject)Instantiate(tiles[Random.Range(0, tiles.Length)], transform.position + offset, transform.rotation);
            tick = 1;
        }
    }
}
