using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesLeftManager : MonoBehaviour {

    Text text; 
    private LevelManager LM;
    public int enemiesLeft;

    private void Awake() {
        text = GetComponent<Text>();
        LM = GameObject.Find("LevelText").GetComponent<LevelManager>();
    }

    // Use this for initialization
    void Start () {
        enemiesLeft = 5;
	}
	
	// Update is called once per frame
	void Update () {
        if (enemiesLeft == 0) {
            LM.currentLevel++;
            enemiesLeft = LM.currentLevel * 5;
        }
        text.text = "Enemies Left - " + enemiesLeft;
    }
}
