using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class LaserBehaviour : MonoBehaviour {
    public float speed;
    public int lifeTime;
    Rigidbody rb;
    public bool isUp = true;
    Vector3 direction;

    void Start() {
        rb = GetComponent<Rigidbody>();
        
        if (isUp) {
            direction = Vector3.up;
        } else {
            direction = Vector3.down;
        }

        Destroy(this.gameObject, lifeTime);
    }

    void Update() {

    }

    void FixedUpdate() {
        rb.velocity = direction * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
