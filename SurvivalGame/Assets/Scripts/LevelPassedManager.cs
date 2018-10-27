using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPassedManager : MonoBehaviour {

    Text text;
    private EnemiesLeftManager ELM;
                    
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        ELM = GameObject.Find("EnemiesLeftText").GetComponent<EnemiesLeftManager>();
        text.text = "";
    }

    // Update is called once per frame
    void Update () {
        if(ELM.enemiesLeft == 0)
            StartCoroutine(ShowTextForABit());
    }

    IEnumerator ShowTextForABit() {
        text.text = "Level Passed!";
        yield return new WaitForSeconds(2f);
        text.text = "";
    }
}
