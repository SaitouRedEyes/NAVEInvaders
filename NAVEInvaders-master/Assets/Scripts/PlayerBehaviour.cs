using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public float speed;
    public GameObject laser;
    public Vector3 laserPosition;
    private Rigidbody rb;
    [SerializeField]
    private Animator animator;
    private float inputH;

    void Awake() {
        animator = GetComponent<Animator>();
        rb = GetComponentInParent<Rigidbody>();
    }

    void Update() {
        if (Input.GetButtonDown("Jump")) {
            Instantiate(laser, transform.position + laserPosition, Quaternion.identity);
        }

        animator.SetFloat("Turn", inputH);
    }

    private void FixedUpdate() {
        inputH = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector3(inputH * speed, 0f);
    }
    
}
