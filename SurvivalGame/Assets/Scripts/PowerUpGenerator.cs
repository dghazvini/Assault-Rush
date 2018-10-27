using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGenerator : MonoBehaviour {

    public GameObject powerUp1; // Heals Player
    public GameObject powerUp2; // Increases run speed for 8 seconds
    public GameObject powerUp3; // Increases jump height for 8 seconds
    public GameObject powerUp4; // Start the next level automatically

    private float randomXValue;
    private float randomZValue;
    Vector3 randomSpawnLocation;

    void Start() {
        InvokeRepeating("SpawnPowerUp1", 0.0f, 18.0f);
        InvokeRepeating("SpawnPowerUp2", 1.0f, 20.0f);
        InvokeRepeating("SpawnPowerUp3", 2.0f, 25.0f);
        InvokeRepeating("SpawnPowerUp4", 30.0f, 30.0f);
    }

    void SpawnPowerUp1() {
        randomXValue = Random.Range(-9.13f, 17.8f);
        randomZValue = Random.Range(-21.57f, 22f);
        randomSpawnLocation = new Vector3(randomXValue, 1.0f, randomZValue);
        Instantiate(powerUp1, randomSpawnLocation, transform.rotation);
    }

    void SpawnPowerUp2() {
        randomXValue = Random.Range(-9.13f, 17.8f);
        randomZValue = Random.Range(-21.57f, 22f);
        randomSpawnLocation = new Vector3(randomXValue, 1.0f, randomZValue);
        Instantiate(powerUp2, randomSpawnLocation, transform.rotation);
    }

    void SpawnPowerUp3() {
        randomXValue = Random.Range(-9.13f, 17.8f);
        randomZValue = Random.Range(-21.57f, 22f);
        randomSpawnLocation = new Vector3(randomXValue, 1.0f, randomZValue);
        Instantiate(powerUp3, randomSpawnLocation, transform.rotation);
    }

    void SpawnPowerUp4() {
        randomXValue = Random.Range(-9.13f, 17.8f);
        randomZValue = Random.Range(-21.57f, 22f);
        randomSpawnLocation = new Vector3(randomXValue, 1.0f, randomZValue);
        Instantiate(powerUp4, randomSpawnLocation, transform.rotation);
    }
}
