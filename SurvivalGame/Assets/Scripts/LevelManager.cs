using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    Text text;        
    public int currentLevel;

    void Start() {
        currentLevel = 1;
    }

    void Awake() {
        text = GetComponent<Text>();
    }

    void Update() {
        text.text = "Level - " + currentLevel;
    }
}
