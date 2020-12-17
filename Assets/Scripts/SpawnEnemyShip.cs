using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyShip : MonoBehaviour
{
    public GameObject prefab;
    public static int seed;
    float checkPoint = 1;
    float spawn = .7f;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        seed = 1;
    }

    // Update is called once per frame
    void Update()
    {

        
        if(Time.time > checkPoint)
        {
            counter++;

            if(counter % 5 == 0)
            {
                seed = -seed;
                counter = 0;
                checkPoint += 4;
            }
            else
            {
                checkPoint += spawn;
                GameObject.Instantiate(prefab, transform.position, prefab.transform.rotation);

            }

        }
        
    }
}
