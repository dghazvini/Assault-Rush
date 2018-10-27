using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public float health;
    AudioSource audioSource;
    public AudioClip hitSound;
    public float Volume;
    private EnemiesLeftManager ELM;
    private Renderer rend;

    // Use this for initialization
    void Start () {
        ELM = GameObject.Find("EnemiesLeftText").GetComponent<EnemiesLeftManager>();
        rend = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(float amount) {
        audioSource.PlayOneShot(hitSound, Volume);
        health -= amount;
        if (health <= 0f)
            Die();
    }

    public void Die() {
        rend.enabled = false;
        ELM.enemiesLeft--;
        StartCoroutine(RemoveEnemy());
    }

    IEnumerator RemoveEnemy() {
        yield return new WaitForSeconds(.1f);
        Destroy(gameObject);
    }
}
