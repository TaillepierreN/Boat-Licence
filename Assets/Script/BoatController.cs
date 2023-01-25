using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    Vector3 _oldPos;
    Vector3 _currentPos;
    [SerializeField] AudioSource _audiosource;
    void Start()
    {
        _oldPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _currentPos = transform.position;
        if(_oldPos != _currentPos)
        {
            if(!_audiosource.isPlaying)
            _audiosource.Play();
            _oldPos=_currentPos;
        }else{
            _audiosource.Stop();
        }
    }
}
