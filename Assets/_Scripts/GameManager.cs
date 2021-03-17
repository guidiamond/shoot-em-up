using UnityEditor;
using UnityEngine;

public class GameManager {

    private static GameManager _instance;
    public enum GameState { MENU, GAME, PAUSE, ENDGAME };

    public GameState gameState {
        get; private set;
    }

    public int vidas;
    public int pontos;

    private void Reset() {
        vidas = 3;
        pontos = 0;
    }
    private GameManager() {
        vidas = 3;
        pontos = 0;
        gameState = GameState.MENU;
    }

    public static GameManager GetInstance() {
        if (_instance == null) {
            _instance = new GameManager();
        }

        return _instance;
    }
}