using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp4Script : MonoBehaviour {
    AudioSource audioSource;
    public AudioClip powerUpSound;
    private Renderer rend;
    GameObject player;
    public float Volume;
    private EnemiesLeftManager ELM;

    // Use this for initialization
    void Start() {
        audioSource = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        ELM = GameObject.Find("EnemiesLeftText").GetComponent<EnemiesLeftManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == player)
            StartNextLevel();
    }

    void StartNextLevel() {
        audioSource.PlayOneShot(powerUpSound, Volume);
        ELM.enemiesLeft = 0;
        rend.enabled = false;
        StartCoroutine(RemovePowerUp());
    }

    IEnumerator RemovePowerUp()
    {
        yield return new WaitForSeconds(.5f);
        Destroy(gameObject);
    }
}
