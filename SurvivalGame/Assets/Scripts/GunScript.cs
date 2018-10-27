using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

    public Camera fpsCam;
    AudioSource audioSource;
    public AudioClip ShootSound;
    public float Volume;
    public float damage = 10f;
    public float range = 100f;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetButtonDown("Fire1"))
            Shoot();
	}

    void Shoot() {
        audioSource.PlayOneShot(ShootSound, Volume);
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
                target.TakeDamage(damage);
        }
    }
}
