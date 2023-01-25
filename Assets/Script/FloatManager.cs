using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatManager : MonoBehaviour
{
    float randBobbing;
    [SerializeField]float rangeMin;
    [SerializeField]float rangeMax;
    [SerializeField]float frequency;
    [SerializeField]float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randBobbing = UnityEngine.Random.Range(rangeMin,rangeMax);
        float newY = Mathf.Sin(Time.time * frequency) * randBobbing + transform.position.y;
        transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,newY,transform.position.z),speed*Time.deltaTime);
    }
}
