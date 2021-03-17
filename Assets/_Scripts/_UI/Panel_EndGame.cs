using UnityEngine;
using UnityEngine.UI;

public class Panel_EndGame : MonoBehaviour {
    public Text message;

    GameManager gm;
    private void OnEnable() {
        gm = GameManager.GetInstance();

        message.text = $"Your score was: {gm.pontos}";
    }

    public void Voltar() {
        gm.isUnPause = false;
        gm.ChangeState(GameManager.GameState.MENU);
    }
}