using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehaviour : MonoBehaviour {

    public float speedRotation;

    void FixedUpdate() {
        transform.Rotate(Vector3.up * speedRotation * Time.deltaTime, Space.Self);
    }
}
