using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PowerUp2Script : MonoBehaviour {

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
            RunFaster();
    }

    void RunFaster() {
        audioSource.PlayOneShot(powerUpSound, Volume);
        rend.enabled = false;
        StartCoroutine(RunFasterFor8Seconds());
    //    StartCoroutine(RemovePowerUp());
    }

    IEnumerator RunFasterFor8Seconds() {
        FPC.movementSettings.ForwardSpeed = 12;
        FPC.movementSettings.StrafeSpeed = 12;
        yield return new WaitForSeconds(8f);
        FPC.movementSettings.ForwardSpeed = 6;
        FPC.movementSettings.StrafeSpeed = 6;
        Destroy(gameObject);
     //   StartCoroutine(RemovePowerUp());
    }
    /*
    IEnumerator RemovePowerUp() {
        yield return new WaitForSeconds(.5f);
        Destroy(gameObject);
    }*/
}
