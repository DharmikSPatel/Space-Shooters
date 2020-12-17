using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 60)
        {
            GameObject.Destroy(this.gameObject);
        }
        float timeSinceStart = Time.time - startTime;
        if (timeSinceStart < .85)
        {
            transform.Translate(0, -2 * Time.deltaTime, 0, Space.World);
        }
        else
        {
            transform.Translate(0, 20f * Time.deltaTime, 0, Space.World);
        }

    }
}
