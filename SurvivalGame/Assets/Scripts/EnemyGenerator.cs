using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip dragonRoarSound;
    public float Volume;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    private float randomXValue;
    private float randomZValue;
    Vector3 randomSpawnLocation;
    private EnemiesLeftManager ELM;
    private int EnemiesToSpawn;
    private int OldEnemyCount;

    // Use this for initialization
    void Start () {
        ELM = GameObject.Find("EnemiesLeftText").GetComponent<EnemiesLeftManager>();
        audioSource = GetComponent<AudioSource>();
        EnemiesToSpawn = ELM.enemiesLeft;
        OldEnemyCount = EnemiesToSpawn;
    }

    private void Update() {

        if (ELM.enemiesLeft > OldEnemyCount)
        {
            EnemiesToSpawn = ELM.enemiesLeft;
            OldEnemyCount = EnemiesToSpawn;
        }
        if (EnemiesToSpawn != 0)
        {
            SpawnEnemy1();
            EnemiesToSpawn--;
        }
        if (EnemiesToSpawn != 0)
        {
            SpawnEnemy2();
            EnemiesToSpawn--;
        }
        if (EnemiesToSpawn != 0)
        {
            SpawnEnemy3();
            EnemiesToSpawn--;
        }
    }

    void SpawnEnemy1() {
        randomXValue = Random.Range(-9.13f, 17.8f);
        randomZValue = Random.Range(-21.57f, 22f);
        randomSpawnLocation = new Vector3(randomXValue, 0.0f, randomZValue);
        Instantiate(enemy1, randomSpawnLocation, transform.rotation);
    }

    void SpawnEnemy2() {
        randomXValue = Random.Range(-9.13f, 17.8f);
        randomZValue = Random.Range(-21.57f, 22f);
        randomSpawnLocation = new Vector3(randomXValue, 0.0f, randomZValue);
        Instantiate(enemy2, randomSpawnLocation, transform.rotation);
    }

    void SpawnEnemy3() {
        randomXValue = Random.Range(-9.13f, 17.8f);
        randomZValue = Random.Range(-21.57f, 22f);
        randomSpawnLocation = new Vector3(randomXValue, 1.0f, randomZValue);
        Instantiate(enemy3, randomSpawnLocation, transform.rotation);
        audioSource.PlayOneShot(dragonRoarSound, Volume);
    }
}
