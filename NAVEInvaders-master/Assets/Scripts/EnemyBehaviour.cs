using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyBehaviour : MonoBehaviour {

    public float speed;
    public int lifeTime;
    public Vector3 laserPosition;
    public GameObject laser;
    Rigidbody rb;
    void Start() {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("Shoot", 1f, 2f);

        Destroy(this.gameObject, lifeTime);
    }

    void Update() {

    }

    void FixedUpdate() {
        rb.velocity = Vector3.down * speed;        
    }

    void Shoot() {
        Instantiate(laser, transform.position + laserPosition, Quaternion.identity).GetComponent<LaserBehaviour>().isUp = false;
    }

    
}