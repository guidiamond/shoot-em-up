using UnityEngine;

public class MonsterSpawner : MonoBehaviour {

    public GameObject Monster1;
    public GameObject Monster2;
    public GameObject Obstacle1;

    GameManager gm;

    private int spawnInterval; // counts in ms

    void Construir() {
        if (gm.isUnPause == false && gm.gameState == GameManager.GameState.GAME) {
            Vector3 posicao = new Vector3(Random.Range(-9.0f , 9.0f) , Random.Range(-3.5f , 3.5f) , 0.0f); // ([10-10],[5,-5],0)
            while (posicao.x >= 3 && posicao.y >= 2) {
                posicao = new Vector3(Random.Range(-9.0f , 9.0f) , Random.Range(-3.5f , 3.5f) , 0.0f); // ([10-10],[5,-5],0)
            }
            int randomMonsterNumber = (int) Random.Range(0.0f , 3.0f);

            if (randomMonsterNumber == 0) {
                Instantiate(Monster1 , posicao , Quaternion.identity , transform);
            }
            else if (randomMonsterNumber == 1) {
                Instantiate(Monster2 , posicao , Quaternion.identity , transform);
            }
            else {
                Instantiate(Obstacle1 , posicao , Quaternion.identity , transform);
            }
        }
        if (gm.gameState == GameManager.GameState.ENDGAME || gm.gameState == GameManager.GameState.MENU) {
            foreach (Transform child in transform) {
                GameObject.Destroy(child.gameObject);
            }
        }
    }
    void Start() {
        gm = GameManager.GetInstance();
        GameManager.changeStateDelegate += Construir;
        Construir();
    }
    void Update() {
        if (Time.time > spawnInterval) {
            spawnInterval = (int) Time.time + 3;
            Construir();
        }


    }
}