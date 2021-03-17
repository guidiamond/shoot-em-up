using UnityEngine;

public class Panel_Menu : MonoBehaviour {
    GameManager gm;

    private void OnEnable() {
        gm = GameManager.GetInstance();
    }

    public void Comecar() {
        gm.isUnPause = false;
        gm.ChangeState(GameManager.GameState.GAME);
    }
}
