using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] NewBehaviourScript objectifs;
    [SerializeField] TMP_Text scoreTxt;
    [SerializeField] TMP_Text scoreTxtfollow;
    [SerializeField] TMP_Text mistakeTxt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = objectifs.objectivesCompleted.ToString();
        if (objectifs.objectivesCompleted != 7 && objectifs.objectivesCompleted + objectifs.objectivesMissed == 7)
        {
            scoreTxt.text = "objectifs échoué";
            scoreTxt.color = Color.red;
            scoreTxtfollow.text = "";
            mistakeTxt.text="";
        }
        else if (objectifs.objectivesCompleted == 7)
        {
            scoreTxt.text = "objectifs accomplie";
            scoreTxt.color = Color.green;
            scoreTxtfollow.text = "";
            scoreTxtfollow.color = Color.green;
            mistakeTxt.text="";
        }
    }
}
