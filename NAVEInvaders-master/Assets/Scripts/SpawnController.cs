using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    public GameObject enemy;

    void Start() {
        InvokeRepeating("Spawn", 1f, 3f);
    }

    // Update is called once per frame
    void Update() {

    }

    void Spawn()
    {
        transform.position = new Vector3(Random.Range(-1.5f, 1.5f), transform.position.y, transform.position.z);
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
