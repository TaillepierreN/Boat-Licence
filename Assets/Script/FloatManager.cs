using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatManager : MonoBehaviour
{
    float randBobbing;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randBobbing = UnityEngine.Random.Range(-0.7f,-0.1f);
        float newY = Mathf.Sin(Time.time * 1.5f) * randBobbing + transform.position.y;
        transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,newY,transform.position.z),2*Time.deltaTime);
    }
}
