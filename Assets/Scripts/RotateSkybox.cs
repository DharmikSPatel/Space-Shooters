using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    public float rotateSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetTextureOffset("_MainTex", new Vector2(-3.15f, rotateSpeed * Time.time));
    }
}
