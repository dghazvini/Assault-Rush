using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip TakeDamageSound;
    public float Volume;
    public int startingHealth = 100;                            
    public int currentHealth;                                   
    public Slider healthSlider;         // Reference to the UI's health bar.
  //  Animator anim;                      // Reference to the Animator component.
    bool isDead;                        // Whether the player is dead.

    void Awake() {
   //     anim = GetComponent<Animator>();
        currentHealth = startingHealth;
        audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        healthSlider.value = currentHealth;
    }

    public void TakeDamage(int amount) {
        audioSource.PlayOneShot(TakeDamageSound, Volume);
        currentHealth -= amount;
        healthSlider.value = currentHealth;

        if(currentHealth <= 0 && isDead == false) {
            Death();
        }
    }

    void Death() {
        // Set the death flag so this function won't be called again.
        isDead = true;
        SceneManager.LoadScene(1);
    }
}