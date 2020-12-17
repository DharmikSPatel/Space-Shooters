using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShip : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
        float i = -Input.GetAxis("Horizontal");

        transform.Translate(-i*40*Time.deltaTime, 0, 0, Space.World);
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -55, 55);
        transform.position = pos;


        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            if ((i < 0 && transform.rotation.z * 180 >= -40) || (i > 0 && transform.rotation.z * 180 <= 40))
              transform.Rotate(0, i * 100 * Time.deltaTime, 0, Space.World);


        }
        else
        {
            float step = 200 * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
        }
    }
}
