using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour {

    private Renderer rend;
    GameObject player;
    PlayerHealth playerHealth;
    private EnemiesLeftManager ELM;
    public int attackDamage;
    public float Volume;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        ELM = GameObject.Find("EnemiesLeftText").GetComponent<EnemiesLeftManager>();
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == player)
            Attack();
    }

    // Damage Player and disappear
    void Attack() {
        playerHealth.TakeDamage(attackDamage);
        rend.enabled = false;
        ELM.enemiesLeft--;
        StartCoroutine(RemoveEnemy());
    }

    IEnumerator RemoveEnemy() {
        yield return new WaitForSeconds(.1f);
        Destroy(gameObject);
    }
}
