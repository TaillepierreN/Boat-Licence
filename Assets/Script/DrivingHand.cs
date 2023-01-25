using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingHand : MonoBehaviour
{
    Vector3 _currentPos;
    bool _currentPosIsSet;
    [SerializeField] GameObject lefthand;
    [SerializeField] GameObject fakehand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCurrentPos()
    {
        if(!_currentPosIsSet)
        {
        _currentPos = transform.position;
        _currentPosIsSet = true;
        }
    }
    public void TeleportToCurrentPos()
    {
        transform.position = _currentPos;
    }
    private void OnTriggerEnter(Collider other) {
        lefthand.SetActive(false);
        fakehand.SetActive(true);

    }
    private void OnTriggerExit(Collider other) {
                lefthand.SetActive(true);
        fakehand.SetActive(false);
    }
}
