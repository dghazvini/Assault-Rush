using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PowerUp3Script : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip powerUpSound;
    private Renderer rend;
    GameObject player;
    public float Volume;
    private RigidbodyFirstPersonController FPC;

    // Use this for initialization
    void Start() {
        audioSource = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        FPC = GameObject.Find("Player").GetComponent<RigidbodyFirstPersonController>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == player)
            JumpHigher();
    }

    void JumpHigher() {
        audioSource.PlayOneShot(powerUpSound, Volume);
        rend.enabled = false;
        StartCoroutine(JumpHigherFor8Seconds());
    }

    IEnumerator JumpHigherFor8Seconds() {
        FPC.movementSettings.JumpForce = 100;
        yield return new WaitForSeconds(8f);
        FPC.movementSettings.JumpForce = 60;
        Destroy(gameObject);
    }
}
