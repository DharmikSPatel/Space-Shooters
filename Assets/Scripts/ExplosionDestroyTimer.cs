﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroyTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(transform.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
