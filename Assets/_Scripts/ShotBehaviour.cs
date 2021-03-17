using UnityEngine;

public class ShotBehaviour : SteerableBehaviour {
    // Start is called before the first frame update
    void Start() {

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player"))
            return;

        IDamageable damageable = collision.gameObject.GetComponent(typeof(IDamageable)) as IDamageable;
        if (!( damageable is null )) {
            damageable.TakeDamage();
        }
        Destroy(collision.gameObject);
    }
    // Update is called once per frame
    private void Update() {
        Thrust(1 , 0);
    }
}
