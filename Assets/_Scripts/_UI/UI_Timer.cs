﻿using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour {
    Text textComp;
    GameManager gm;
    // Start is called before the first frame update
    void Start() {
        textComp = GetComponent<Text>();
        gm = GameManager.GetInstance();

    }

    // Update is called once per frame
    void Update() {
        textComp.text = $"Timer: {gm.timer}";

    }
}
