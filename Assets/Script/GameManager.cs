using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] NewBehaviourScript Objectifs; 
    // Start is called before the first frame update
    void Start()
    {
        Objectifs.objectivesCompleted =0;
        Objectifs.objectivesMissed =0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);

    }
}
