using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TriggerManager : MonoBehaviour
{
    [SerializeField] NewBehaviourScript objectifs;
    [SerializeField] TMP_Text mistakeTxt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("GoodWay"))
        {
            objectifs.objectivesCompleted += 1;
        } else{
            objectifs.objectivesMissed +=1;
            mistakeTxt.text += "X";
        }
            gameObject.SetActive(false);
    }
}
