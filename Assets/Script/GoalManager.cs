using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    [SerializeField]GameManager _gm;
    private void OnTriggerEnter(Collider other) {
        _gm.BackToMainMenu();
    }
}
