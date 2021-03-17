﻿using UnityEngine;
using UnityEngine.UI;

public class UI_Countdown : MonoBehaviour {
    Text textComp;
    GameManager gm;
    void Start() {
        textComp = GetComponent<Text>();
        gm = GameManager.GetInstance();
    }

    void Update() {
        textComp.text = $"Countdown: {gm.timeToLose}";
    }
}
