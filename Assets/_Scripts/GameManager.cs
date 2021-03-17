﻿using UnityEditor;
using UnityEngine;

public class GameManager {

    private static GameManager _instance;
    public enum GameState { MENU, GAME, PAUSE, ENDGAME };

    public delegate void ChangeStateDelegate();
    public static ChangeStateDelegate changeStateDelegate;

    // Used on BlocoSpawner.Construir and GameManager.ChangeState so if the game is unpaused it doesn't reset the scores
    public bool isUnPause = false;

    public int timer; // B30
    public int enemiesLeft; // B30
    public int timeToLose; // B31

    public GameState gameState {
        get; private set;
    }

    public int vidas;
    public int pontos;

    private void Reset() {
        vidas = 3;
        pontos = 0;
        timer = 0;
        timeToLose = 120;
        enemiesLeft = 30;
    }

    public void ChangeState(GameState nextState) {
        if (nextState == GameState.GAME && isUnPause == false) {
            Reset();
        }
        if (nextState == GameState.GAME) {
            Time.timeScale = 1;
        }
        else {
            Time.timeScale = 0;
        }
        gameState = nextState;
        changeStateDelegate();
    }

    private GameManager() {
        vidas = 3;
        pontos = 0;
        gameState = GameState.MENU;
        Time.timeScale = 0;
    }

    public static GameManager GetInstance() {
        if (_instance == null) {
            _instance = new GameManager();
        }

        return _instance;
    }
}