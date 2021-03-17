using UnityEngine;

public class Panel_Pause : MonoBehaviour {

    GameManager gm;

    private void OnEnable() {
        gm = GameManager.GetInstance();
    }

    public void Retornar() {
        gm.isUnPause = true;
        gm.ChangeState(GameManager.GameState.GAME);
    }

    public void Inicio() {
        gm.isUnPause = false;
        gm.ChangeState(GameManager.GameState.MENU);
    }

}