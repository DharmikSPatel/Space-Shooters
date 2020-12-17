using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMissile : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        
    }
    void Update()
    {


        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int ran = Random.Range(0, 2);
            if (ran == 1)
            {
                GameObject.Instantiate(prefab, new Vector3(transform.position.x + -3.9f, -3.4f, -.4f), transform.rotation);
            }
            else
            {
                GameObject.Instantiate(prefab, new Vector3(transform.position.x + 3.8f, -3.4f, -.4f), transform.rotation);
            }
            
        }
    }
}
