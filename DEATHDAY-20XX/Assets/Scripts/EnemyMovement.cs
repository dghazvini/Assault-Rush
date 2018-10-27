using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;

    void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        target = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update() {
        agent.SetDestination(target.position); // move towards the target while avoiding things
    }
}
