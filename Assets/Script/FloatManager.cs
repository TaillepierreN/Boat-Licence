using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x,Mathf.Sin(1),transform.position.z),2*Time.deltaTime);
    }
}
