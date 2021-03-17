using UnityEngine;

public class ShotBehaviour : SteerableBehaviour {

    GameManager gm;
    // Start is called before the first frame update
    void Start() {
        gm = GameManager.GetInstance();

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player"))
            return;
        if (!( collision.gameObject is null )) {
            Destroy(collision.gameObject);
            gm.pontos += 10;
            gm.enemiesLeft--;
        }
        Destroy(gameObject);
        if (gm.enemiesLeft <= 0) {
            gm.ChangeState(GameManager.GameState.ENDGAME);
        }
    }
    // Update is called once per frame
    private void Update() {
        Thrust(1 , 0);
    }
}
