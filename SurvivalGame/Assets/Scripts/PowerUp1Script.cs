using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp1Script : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip powerUpSound;
    private Renderer rend;
    GameObject player;
    private PlayerHealth PH;
    public float Volume;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        PH = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update () {
	}

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == player)
            Heal();
    }

    void Heal() {
        audioSource.PlayOneShot(powerUpSound, Volume);
        rend.enabled = false;
        PH.currentHealth = 100;
        StartCoroutine(RemovePowerUp());
    }

    IEnumerator RemovePowerUp() {
        yield return new WaitForSeconds(.5f);
        Destroy(gameObject);
    }
}
