using UnityEngine;
using UnityEngine.UI;

public class Panel_EndGame : MonoBehaviour {
    public Text message;

    GameManager gm;
    private void OnEnable() {
        gm = GameManager.GetInstance();
        if (gm.vidas > 0 && gm.timeToLose > 0 || gm.enemiesLeft <= 0) {
            message.text = $"You won!!! Score: {gm.pontos}";
        }
        else {
            message.text = $"You lost!!, Score: {gm.pontos}";
        }
    }

    public void Voltar() {
        gm.isUnPause = false;
        gm.ChangeState(GameManager.GameState.MENU);
    }
}